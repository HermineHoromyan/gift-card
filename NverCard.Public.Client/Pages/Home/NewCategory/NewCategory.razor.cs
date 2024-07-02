using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using NverCard.Public.Client.ServiceProxies.Queries.Contents;
using NverCard.Public.Client.ServiceProxies.Queries.Products.Models;
using NverCard.Public.Client.Services.ProductService;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NverCard.Public.Client.Pages.Home.NewCategory
{
    public partial class NewCategory
    {
        #region Inject

        [Inject]
        IProductService ProductService { get; set; }

        [Inject]
        GetSlidersQueryProxy GetSlidersQueryProxy { get; set; }

        [Inject]
        IJSRuntime JSRuntime { get; set; }

        #endregion Inject

        #region Properties

        /// <summary>
        /// New arrivals
        /// </summary>
        private IEnumerable<ProductShortInfoModel> NewArrivalsProducts { get; set; }

        #endregion Properties

        #region Methods

        protected override async Task OnInitializedAsync()
        {
            var products = await ProductService.GetProductsByTagSeoLinks(new List<string>() { "new-arrivals" });
            NewArrivalsProducts = products.Where(p => p.ProductTags.Any(t => t.SeoLink == "new-arrivals"));
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await JSRuntime.InvokeVoidAsync("swiperConfig.init");
        }

        #endregion Methods
    }
}
