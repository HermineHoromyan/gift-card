using Blazored.LocalStorage;
using System.Threading.Tasks;

namespace NverCard.Public.Client.Services.LocalStorageService
{
    public class LocalStorageProvider : ILocalStorageProvider
    {
        #region Const

        private const string FavoriteKey = "nc.customer.favorits";
        private const string ShoppingCartItemKey = "nc.customer.shoppingcartitem";
        //private const string CartKey = "nc.customer.cart";
        private const string CategoriesKey = "nc.public.categories";
        private const string TagsKey = "nc.public.tags";

        #endregion Const

        #region Fileds

        private readonly ILocalStorageService localStorage;
        private readonly ISyncLocalStorageService syncLocalStorage;

        #endregion Fields

        #region Constructor

        public LocalStorageProvider(ILocalStorageService localStorage, ISyncLocalStorageService syncLocalStorage)
        {
            this.localStorage = localStorage;
            this.syncLocalStorage = syncLocalStorage;
        }

        #endregion Constructor

        #region Properties

        /// <summary>
        /// Favorits
        /// </summary>
        private string LocalStorageFavorits { get; set; }

        /// <summary>
        /// Cart
        /// </summary>
        private string LocalStorageCartItems { get; set; }

        /// <summary>
        /// Cart
        /// </summary>
        private string LocalStorageCategories { get; set; }


        /// <summary>
        /// Cart
        /// </summary>
        private string LocalStorageTags { get; set; }


        #endregion Properties

        #region Methods

        public async Task Load()
        {
            LocalStorageFavorits = await localStorage.GetItemAsync<string>(FavoriteKey);
            LocalStorageCartItems = await localStorage.GetItemAsync<string>(ShoppingCartItemKey);
            LocalStorageCategories = await localStorage.GetItemAsync<string>(CategoriesKey);
            LocalStorageTags = await localStorage.GetItemAsync<string>(TagsKey);
        }

        //#region Favorits storage

        ///// <summary>
        ///// set favorits in localstorage
        ///// </summary>
        //public async Task SetFavorits(List<Guid> favorits)
        //{
        //    try
        //    {
        //        await localStorage.SetItemAsync(FavoriteKey, favorits);
        //    }
        //    catch (Exception)
        //    {
        //        await localStorage.RemoveItemAsync(FavoriteKey);
        //    }

        //}

        ///// <summary>
        ///// Remove favorits from localstorage
        ///// </summary>
        //public async Task CleanFavorits()
        //{
        //    await localStorage.RemoveItemAsync(FavoriteKey);
        //}

        ///// <summary>
        ///// Get favorits from localstorage
        ///// </summary>
        //public async Task<List<Guid>> GetFavorits()
        //{
        //    try
        //    {
        //        List<Guid> favorits = await localStorage.GetItemAsync<List<Guid>>(FavoriteKey);
        //        return favorits;
        //    }
        //    catch (Exception)
        //    {
        //        await localStorage.RemoveItemAsync(FavoriteKey);
        //    }

        //    return null;
        //}

        ///// <summary>
        ///// Get favorits count from localstorage
        ///// </summary>
        //public int GetFavoritsCount()
        //{
        //    try
        //    {
        //        var favorits = syncLocalStorage.GetItem<List<Guid>>(FavoriteKey);
        //        return favorits != null ? favorits.Count : 0;
        //    }
        //    catch (Exception)
        //    {
        //        syncLocalStorage.RemoveItem(FavoriteKey);
        //    }

        //    return 0;
        //}

        //#endregion Favorits storage

        #endregion Methods
    }
}
