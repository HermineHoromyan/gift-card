using NverCard.Public.Client.ServiceProxies.Queries.Products.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NverCard.Public.Client.Services.ProductService
{
    public interface IProductService
    {
        event Action OnProductChange;

        /// <summary>
        /// Get products for paging
        /// </summary>
        public Task<ProductPageShortInfoModel> GetProductsPageShortInfoBySeoName(GetProductsPagingModel model);

        /// <summary>
        /// Get product list by tag seo link
        /// </summary>
        public Task<IEnumerable<ProductShortInfoModel>> GetProductsByTagSeoLinks(List<string> tagSeoLinks);

        /// <summary>
        /// Get product short info list by ids
        /// </summary>
        public Task<List<ProductShortInfoModel>> GetProductsShortInfoByIds(List<Guid> ids);

    }
}
