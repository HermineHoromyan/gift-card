using NverCard.Public.Client.ServiceProxies.Queries.CustomerOrders;
using NverCard.Public.Client.ServiceProxies.Queries.CustomerOrders.Models;
using NverCard.Public.Client.ServiceProxies.Queries.GiftCertificates;
using NverCard.Public.Client.ServiceProxies.Queries.GiftCertificates.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NverCard.Public.Client.Services.OrderService
{
    public class OrderService : IOrderService
    {
        #region Constructor
        public OrderService(
            GetCustomerOrdersQueryProxy GetCustomerOrdersQueryProxy,
            GetCustomerGiftCertificatesQueryProxy GetCustomerGiftCertificatesQueryProxy
            )
        {
            this.GetCustomerOrdersQueryProxy = GetCustomerOrdersQueryProxy;
            this.GetCustomerGiftCertificatesQueryProxy = GetCustomerGiftCertificatesQueryProxy;
        }

        #endregion Constructor

        #region Fields
        public GetCustomerOrdersQueryProxy GetCustomerOrdersQueryProxy { get; }
        public GetCustomerGiftCertificatesQueryProxy GetCustomerGiftCertificatesQueryProxy { get; }

        public event Action OnChange;

        #endregion Fields

        #region Methods

        /// <summary>
        /// Return customer orders
        /// </summary>
        public async Task<IEnumerable<CustomerOrderModel>> GetCustomerOrders()
        {
            OnChange?.Invoke();
            return await GetCustomerOrdersQueryProxy.Execute();
        }

        /// <summary>
        /// Get customer all certificates from all orders
        /// </summary>
        public async Task<IEnumerable<CertificateModel>> GetCustomerCards(CertificateInputModel inputModel)
        {
            OnChange?.Invoke();
            return await GetCustomerGiftCertificatesQueryProxy.Execute(inputModel);

        }

        #endregion Methods
    }
}
