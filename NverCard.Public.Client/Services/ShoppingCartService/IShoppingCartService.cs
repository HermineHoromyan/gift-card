using NverCard.Public.Client.ServiceProxies.Queries.ShoppingCarts.Models;
using System;
using System.Threading.Tasks;

namespace NverCard.Public.Client.Services.ShoppingCartService
{
    public interface IShoppingCartService
    {
        event Action OnChange;

        /// <summary>
        /// Add item to customer shopping cart
        /// </summary>
        public Task AddItemToCustomerShoppingCartAsync(ShoppingCartItemModel item);

        /// <summary>
        /// Ge customer shopping cart
        /// </summary>
        public Task<ShoppingCartModel> GetCustomerShoppingCartAsync();

        /// <summary>
        /// Edit shopping cart item for customer
        /// </summary>
        public Task EditCustomerShoppingCartItem(ShoppingCartItemModel item);

        /// <summary>
        /// Remove local storage item from customer cart
        /// </summary>
        public Task RemoveItemFromCustomerShoppingCartAsync(Guid itemId);

        /// <summary>
        /// Get shopping cart items count
        /// </summary>
        public Task<int> GetShoppingCartItemsCount();

        /// <summary>
        /// Get shopping cart amount
        /// </summary>
        /// <returns></returns>
        public Task<int> GetShoppingCartAmount();
    }
}
