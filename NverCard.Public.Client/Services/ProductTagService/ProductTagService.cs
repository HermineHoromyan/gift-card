using NverCard.Public.Client.ServiceProxies.Queries.ProductTags;
using NverCard.Public.Client.ServiceProxies.Queries.ProductTags.Models;
using NverCard.Public.Client.Services.LocalStorageService;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NverCard.Public.Client.Services.ProductTagService
{
    public class ProductTagService : IProductTagService
    {
        #region Constructor

        public ProductTagService(GetAvailableProductTagsQueryProxy GetAvailableProductTagsQueryProxy, ILocalStorageProvider LocalStorageProvider)
        {
            this.GetAvailableProductTagsQueryProxy = GetAvailableProductTagsQueryProxy;
            this.LocalStorageProvider = LocalStorageProvider;
        }


        #endregion Constructor

        #region Fields
        public GetAvailableProductTagsQueryProxy GetAvailableProductTagsQueryProxy { get; }
        public ILocalStorageProvider LocalStorageProvider { get; }

        #endregion Fileds

        #region Methods

        public async Task<List<ProductTagModel>> GetProductTags()
        {
            IEnumerable<ProductTagModel> resultTags = await GetAvailableProductTagsQueryProxy.Execute();
            //await LocalStorageProvider.SetProductTags(resultTags.ToList());

            return resultTags.ToList();
        }

        #endregion Methods


    }
}
