using NverCard.Public.Client.ServiceProxies.Queries.ProductCategories.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NverCard.Public.Client.Services.ProductCategoryService
{
    public interface IProductCategoryService
    {
        public Task<List<ProductCategoryModel>> GetProductCategories();

    }
}
