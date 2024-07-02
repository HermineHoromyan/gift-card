using NverCard.Public.Client.ServiceProxies.Queries.ProductTags.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NverCard.Public.Client.Services.ProductTagService
{
    public interface IProductTagService
    {
        public Task<List<ProductTagModel>> GetProductTags();

    }
}
