using NverCard.Public.Client.ServiceProxies.Queries.Products.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NverCard.Public.Client.Services.FavoritService
{
    public interface IFavoritService
    {
        event Action OnChange;

        public List<Guid> Favorits { get; set; }

        /// <summary>
        /// Add customer favorit
        /// </summary>
        public Task AddToFavorit(Guid productId);

        /// <summary>
        /// Remove customer favorit by id
        /// </summary>
        public Task RemoveFromFavorit(Guid productId);

        /// <summary>
        /// Get cutomer favorit Ids
        /// </summary>
        public Task<List<Guid>> GetCustomerFavorits();

        /// <summary>
        /// Get customer favorit count
        /// </summary>
        public Task<int> GetCustomerFavoritsCount();

        /// <summary>
        /// Get cutomer favorit products short info
        /// </summary>
        public Task<List<ProductShortInfoModel>> GetCustomerFavoritProducts();

    }
}
