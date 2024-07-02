using Microsoft.AspNetCore.Components;
using NverCard.Public.Client.InteropServices;
using NverCard.Public.Client.Modal.QrcodeModal;
using NverCard.Public.Client.ServiceProxies.Queries.GiftCertificates;
using NverCard.Public.Client.ServiceProxies.Queries.GiftCertificates.Models;
using NverCard.Public.Client.Services.OrderService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NverCard.Public.Client.Pages.Account_cards
{
    public partial class Account_cards
    {
        #region Inject


        [Inject]
        private UserSession UserSession { get; set; }

        [Inject]
        IOrderService OrderService { get; set; }

        [Inject]
        private GetCustomerGiftCertificatePdfCommandProxy GetCustomerGiftCertificatePdfCommandProxy { get; set; }

        [Inject]
        private Downloader Downloader { get; set; }

        [Inject]
        private GetCustomerGiftCertificateBarCodeQueryProxy GetCustomerGiftCertificateBarCodeQueryProxy { get; set; }

        #endregion Inject

        #region Const

        private string ActiveTypeText = "Ակտիվ";
        private string PdfText = "PDF";
        private string AllTypeText = "Բոլորը";

        #endregion Const

        #region Properties

        /// <summary>
        /// Loader for barcode button
        /// </summary>
        private bool BarcodeButtonLoading { get; set; }

        /// <summary>
        /// Loader for pdf button
        /// </summary>
        private bool PdfButtonLoading { get; set; }

        /// <summary>
        /// Loading item id
        /// </summary>
        private Guid? LoadingItemId { get; set; }

        public string AccountName { get; set; }

        public bool OnlyActives { get; set; } = true;

        public int? Months { get; set; } = 1;

        /// <summary>
        /// Certificates
        /// </summary>
        public IEnumerable<CertificateModel> GiftCertificates { get; set; }

        #endregion Properties

        #region Reference

        private QrcodeModal qrcodeModal;

        #endregion Reference

        #region Methods

        private async Task DownloadPdf(Guid certId)
        {
            if(!PdfButtonLoading && !LoadingItemId.HasValue)
            {
                //Начинаем загрузку данных
                PdfButtonLoading = true;
                LoadingItemId = certId;
                var pdfModel = await GetCustomerGiftCertificatePdfCommandProxy.Execute(certId);

                //Возвращаем как скачиваемый файл
                await Downloader.DownloadFileAsync(pdfModel.Data, $"{pdfModel.FileName}", "application/pdf");

                //Заканчиваем загрузку данных
                PdfButtonLoading = false;
                LoadingItemId = null;
            }            
        }

        private async Task ShowBarcode(Guid certId)
        {
            if (!BarcodeButtonLoading && !LoadingItemId.HasValue)
            {
                BarcodeButtonLoading = true;
                LoadingItemId = certId;
                var url = await GetCustomerGiftCertificateBarCodeQueryProxy.Execute(certId);
                qrcodeModal.Open(url);
                BarcodeButtonLoading = false;
                LoadingItemId = null;
            }            
        }

        private async Task SelelectActiveCards(bool isActiveCards)
        {
            OnlyActives = isActiveCards;
            await LoadData();
            StateHasChanged();
        }

        private async Task SelelectMonths(int? months)
        {
            Months = months;
            await LoadData();
            StateHasChanged();
        }

        private string GetMontsStringValue()
        {
            return Months == 1 ? "Վերջին 1 ամիսը" : Months == 6 ? "Վերջին 6 ամիսը" : Months == 12 ? "Վերջին 12 ամիսը" : "Բոլորը";
        }

        private async Task LoadData()
        {
            GiftCertificates = await OrderService.GetCustomerCards(new CertificateInputModel { Months = Months, OnlyActive = OnlyActives });

            if (GiftCertificates.Count() == 0)
                GiftCertificates = new List<CertificateModel>();
        }

        protected override async Task OnInitializedAsync()
        {
            await UserSession.LoadSession();
            if (UserSession.IsSessionStarted)
            {
                await LoadData();
                AccountName = UserSession.Name;
            }

        }

        #endregion Methods
    }
}
