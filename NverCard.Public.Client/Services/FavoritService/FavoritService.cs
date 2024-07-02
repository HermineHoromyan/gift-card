using NverCard.Public.Client.ServiceProxies.Commands.Favorits;
using NverCard.Public.Client.ServiceProxies.Queries.Favorits;
using NverCard.Public.Client.ServiceProxies.Queries.Products;
using NverCard.Public.Client.ServiceProxies.Queries.Products.Models;
using NverCard.Public.Client.Services.LocalStorageService;
using NverCard.Public.Client.Services.ToastService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NverCard.Public.Client.Services.FavoritService
{
    public class FavoritService : IFavoritService
    {
        #region Fields
        public event Action OnChange;
        //public event Action<Func<Task>> OnChangeRebind;

        private readonly ILocalStorageProvider localStorageProvider;
        private readonly IToastService toastService;
        public List<Guid> Favorits { get; set; }
        public RemoveFavoriteByProductIdCommandProxy RemoveFavoriteByProductIdCommandProxy { get; }
        public GetCustomerFavoritProductsShortInfoQueryProxy GetCustomerFavoritProductsShortInfoQueryProxy { get; }
        public GetCustomerFavoritsQueryProxy GetCustomerFavoritsQueryProxy { get; }
        public CreateFavoriteCommandProxy CreateFavoriteCommandProxy { get; set; }
        public CreateFavoritesCommandProxy CreateFavoritesCommandProxy { get; }
        public GetCustomerFavoritsCountQueryProxy GetCustomerFavoritsCountQueryProxy { get; }
        public UserSession UserSession { get; set; }

        #endregion Fields

        public FavoritService(
            ILocalStorageProvider localStorageProvider,
            RemoveFavoriteByProductIdCommandProxy RemoveFavoriteByProductIdCommandProxy,
            GetCustomerFavoritProductsShortInfoQueryProxy GetCustomerFavoritProductsShortInfoQueryProxy,
            GetCustomerFavoritsQueryProxy GetCustomerFavoritsQueryProxy,
            CreateFavoriteCommandProxy CreateFavoriteCommandProxy,
            CreateFavoritesCommandProxy CreateFavoritesCommandProxy,
            GetCustomerFavoritsCountQueryProxy GetCustomerFavoritsCountQueryProxy,
            IToastService toastService,
            UserSession userSession
            )
        {
            this.localStorageProvider = localStorageProvider;
            this.RemoveFavoriteByProductIdCommandProxy = RemoveFavoriteByProductIdCommandProxy;
            this.GetCustomerFavoritProductsShortInfoQueryProxy = GetCustomerFavoritProductsShortInfoQueryProxy;
            this.GetCustomerFavoritsQueryProxy = GetCustomerFavoritsQueryProxy;
            this.CreateFavoriteCommandProxy = CreateFavoriteCommandProxy;
            this.CreateFavoritesCommandProxy = CreateFavoritesCommandProxy;
            this.GetCustomerFavoritsCountQueryProxy = GetCustomerFavoritsCountQueryProxy;
            this.toastService = toastService;
            UserSession = userSession;
        }

        /// <summary>
        /// Add customer favorit
        /// </summary>
        public async Task AddToFavorit(Guid productId)
        {
            var anonymUserId = await CreateFavoriteCommandProxy.Execute(productId);

            if (!UserSession.IsSessionStarted && anonymUserId.HasValue)
            {
                await UserSession.SetUserId(anonymUserId.Value);
            }
            await toastService.AddFavorit();
            OnChange?.Invoke();
        }

        /// <summary>
        /// Remove customer favorit by id
        /// </summary>
        public async Task RemoveFromFavorit(Guid productId)
        {
            await RemoveFavoriteByProductIdCommandProxy.Execute(productId);
            await toastService.RemoveFavorit();
            OnChange?.Invoke();
        }

        /// <summary>
        /// Get customer favorit count
        /// </summary>
        public async Task<int> GetCustomerFavoritsCount()
        {
            return await GetCustomerFavoritsCountQueryProxy.Execute();
        }


        /// <summary>
        /// Get cutomer favorit Ids
        /// </summary>
        public async Task<List<Guid>> GetCustomerFavorits()
        {
            var result = await GetCustomerFavoritsQueryProxy.Execute();
            return result != null ? result.Select(f => f.ProductId).ToList() : new List<Guid>();
        }

        /// <summary>
        /// Get cutomer favorit products short info
        /// </summary>
        public async Task<List<ProductShortInfoModel>> GetCustomerFavoritProducts()
        {
            var result = await GetCustomerFavoritProductsShortInfoQueryProxy.Execute();
            return result.ToList();
        }

    }
}
