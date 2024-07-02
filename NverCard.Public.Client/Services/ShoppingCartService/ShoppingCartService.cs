using NverCard.Public.Client.ServiceProxies.Commands.Favorits;
using NverCard.Public.Client.ServiceProxies.Commands.ShoppingCarts;
using NverCard.Public.Client.ServiceProxies.Commands.ShoppingCarts.Models;
//using NverCard.Public.Client.ServiceProxies.Commands.ShoppingCarts.Models;
using NverCard.Public.Client.ServiceProxies.Queries.ShoppingCarts;
using NverCard.Public.Client.ServiceProxies.Queries.ShoppingCarts.Models;
using NverCard.Public.Client.Services.LocalStorageService;
using NverCard.Public.Client.Services.ToastService;
using System;
using System.Threading.Tasks;

namespace NverCard.Public.Client.Services.ShoppingCartService
{
    public class ShoppingCartService : IShoppingCartService
    {
        #region Fields

        public RemoveShoppingCartItemCommandProxy RemoveShoppingCartItemCommandProxy { get; }
        public GetCustomerShoppingCartQueryProxy GetCustomerShoppingCartQueryProxy { get; }
        public CreateShoppingCartItemCommandProxy CreateShoppingCartItemCommandProxy { get; }
        public UpdateShoppingCartItemCommandProxy UpdateShoppingCartItemCommandProxy { get; }
        public GetCustomerShoppingCartItemsCountQueryProxy GetCustomerShoppingCartItemsCountQueryProxy { get; }
        public GetShoppingCartItemsAmountQueryProxy GetShoppingCartItemsAmountQueryProxy { get; }

        public event Action OnChange;
        private readonly ILocalStorageProvider localStorageProvider;
        private readonly IToastService toastService;
        private readonly UserSession UserSession;

        #endregion Fileds
               
        #region Construstor
        public ShoppingCartService(
            ILocalStorageProvider localStorageProvider,
            RemoveShoppingCartItemCommandProxy RemoveShoppingCartItemCommandProxy,
            GetCustomerShoppingCartQueryProxy GetCustomerShoppingCartQueryProxy,
            CreateShoppingCartItemCommandProxy CreateShoppingCartItemCommandProxy,
            UpdateShoppingCartItemCommandProxy UpdateShoppingCartItemCommandProxy,
            GetCustomerShoppingCartItemsCountQueryProxy GetCustomerShoppingCartItemsCountQueryProxy,
            GetShoppingCartItemsAmountQueryProxy GetShoppingCartItemsAmountQueryProxy,
            IToastService toastService,
            UserSession UserSession)
        {
            this.localStorageProvider = localStorageProvider;
            this.RemoveShoppingCartItemCommandProxy = RemoveShoppingCartItemCommandProxy;
            this.GetCustomerShoppingCartQueryProxy = GetCustomerShoppingCartQueryProxy;
            this.CreateShoppingCartItemCommandProxy = CreateShoppingCartItemCommandProxy;
            this.UpdateShoppingCartItemCommandProxy = UpdateShoppingCartItemCommandProxy;
            this.GetCustomerShoppingCartItemsCountQueryProxy = GetCustomerShoppingCartItemsCountQueryProxy;
            this.GetShoppingCartItemsAmountQueryProxy = GetShoppingCartItemsAmountQueryProxy;
            this.toastService = toastService;
            this.UserSession = UserSession;
        }
        #endregion Cunstructor

        #region Methods

        /// <summary>
        /// Add item to customer shopping cart
        /// </summary>
        public async Task AddItemToCustomerShoppingCartAsync(ShoppingCartItemModel item)
        {
            Console.WriteLine($"{item.OfferId}:{item.Quantity}");
            //if (UserSession.IsSessionStarted)
            var result = await CreateShoppingCartItemCommandProxy.Execute(new CreateShoppingCartItemModel
            {
                OfferId = item.OfferId,
                Quantity = item.Quantity
            });

            await toastService.AddShoppingCartItem();

            if (!UserSession.IsSessionStarted)
            {
                await UserSession.SetUserId(result.CustomerId);
            }

            OnChange?.Invoke();
        }

        /// <summary>
        /// Edit shopping cart item for customer
        /// </summary>
        public async Task EditCustomerShoppingCartItem(ShoppingCartItemModel item)
        {
            await UpdateShoppingCartItemCommandProxy.Execute(new UpdateShoppingCartItemModel { OfferId = item.OfferId, Quantity = item.Quantity, ShoppingCartId = item.ShoppingCartId});
            OnChange?.Invoke();
        }

        /// <summary>
        /// Get shopping cart items count in localstorage
        /// </summary>
        public async Task<int> GetShoppingCartItemsCount()
        {
            return await GetCustomerShoppingCartItemsCountQueryProxy.Execute();
        }

        /// <summary>
        /// Ge customer shopping cart
        /// </summary>
        public async Task<ServiceProxies.Queries.ShoppingCarts.Models.ShoppingCartModel> GetCustomerShoppingCartAsync()
        {
            return await GetCustomerShoppingCartQueryProxy.Execute();
        }

        /// <summary>
        /// Remove local storage item from customer cart
        /// </summary>
        public async Task RemoveItemFromCustomerShoppingCartAsync(Guid itemId)
        {
            await RemoveShoppingCartItemCommandProxy.Execute(itemId);
            await toastService.RemoveShoppingCartItem();
            OnChange?.Invoke();
        }

        /// <summary>
        /// Get shopping cart amount
        /// </summary>
        /// <returns></returns>
        public async Task<int> GetShoppingCartAmount()
        {
            return await GetShoppingCartItemsAmountQueryProxy.Execute();
        }

        #endregion Methods
    }
}
