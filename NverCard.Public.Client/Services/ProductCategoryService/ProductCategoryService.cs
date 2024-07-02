using NverCard.Public.Client.ServiceProxies.Queries.ProductCategories;
using NverCard.Public.Client.ServiceProxies.Queries.ProductCategories.Models;
using NverCard.Public.Client.Services.LocalStorageService;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NverCard.Public.Client.Services.ProductCategoryService
{
    public class ProductCategoryService : IProductCategoryService
    {
        #region Constructor

        public ProductCategoryService(GetAvailableProductCategoriesQueryProxy GetAvailableProductCategoriesQueryProxy, ILocalStorageProvider LocalStorageProvider)
        {
            this.GetAvailableProductCategoriesQueryProxy = GetAvailableProductCategoriesQueryProxy;
            this.LocalStorageProvider = LocalStorageProvider;
        }

        #endregion Constructor

        #region Fields

        public GetAvailableProductCategoriesQueryProxy GetAvailableProductCategoriesQueryProxy { get; }
        public ILocalStorageProvider LocalStorageProvider { get; }

        #endregion Fields

        #region Methods

        public async Task<List<ProductCategoryModel>> GetProductCategories()
        {
            IEnumerable<ProductCategoryModel> result = await GetAvailableProductCategoriesQueryProxy.Execute();
            //await LocalStorageProvider.SetProductCategories(JsonConvert.SerializeObject(result.ToList()));

            return result.ToList();
        }

        #endregion Methods
    }
}
