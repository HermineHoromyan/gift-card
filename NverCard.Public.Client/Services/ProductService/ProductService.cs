using NverCard.Public.Client.ServiceProxies.Queries.Products;
using NverCard.Public.Client.ServiceProxies.Queries.Products.Models;
using NverCard.Public.Client.Services.FavoritService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NverCard.Public.Client.Services.ProductService
{
    public class ProductService : IProductService
    {
        #region Constructor

        public ProductService(
            GetProductsPageShortInfoBySeoLinkQueryProxy GetProductsPageShortInfoBySeoLinkQueryProxy,
            GetProductsShortInfoByProductTagSeoQueryProxy GetProductsShortInfoByProductTagSeoQueryProxy,
            GetAvailableProductsShortInfoByIdsQueryProxy GetAvailableProductsShortInfoByIdsQueryProxy,
            IFavoritService FavoritService
            )
        {
            this.GetProductsPageShortInfoBySeoLinkQueryProxy = GetProductsPageShortInfoBySeoLinkQueryProxy;
            this.GetProductsShortInfoByProductTagSeoQueryProxy = GetProductsShortInfoByProductTagSeoQueryProxy;
            this.GetAvailableProductsShortInfoByIdsQueryProxy = GetAvailableProductsShortInfoByIdsQueryProxy;
            this.FavoritService = FavoritService;
        }

        #endregion Constructor

        #region Fields

        public GetProductsPageShortInfoBySeoLinkQueryProxy GetProductsPageShortInfoBySeoLinkQueryProxy { get; }
        public GetProductsShortInfoByProductTagSeoQueryProxy GetProductsShortInfoByProductTagSeoQueryProxy { get; }
        public GetAvailableProductsShortInfoByIdsQueryProxy GetAvailableProductsShortInfoByIdsQueryProxy { get; }
        public IFavoritService FavoritService { get; }

        public event Action OnProductChange;

        #endregion Fields

        #region Methods

        /// <summary>
        /// Get products for paging
        /// </summary>
        public async Task<ProductPageShortInfoModel> GetProductsPageShortInfoBySeoName(GetProductsPagingModel model)
        {
            return await GetProductsPageShortInfoBySeoLinkQueryProxy.Execute(model);
        }

        /// <summary>
        /// Get product list by tag seo link
        /// </summary>
        public async Task<IEnumerable<ProductShortInfoModel>> GetProductsByTagSeoLinks(List<string> tagSeoLinks)
        {
            OnProductChange?.Invoke();
            return await GetProductsShortInfoByProductTagSeoQueryProxy.Execute(tagSeoLinks);
        }

        /// <summary>
        /// Get product short info list by ids
        /// </summary>
        public async Task<List<ProductShortInfoModel>> GetProductsShortInfoByIds(List<Guid> ids)
        {
            var result = await GetAvailableProductsShortInfoByIdsQueryProxy.Execute(ids);

            return result.ToList();
        }

        #endregion Methods

    }
}
