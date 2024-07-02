using System.Threading.Tasks;

namespace NverCard.Public.Client.Services.LocalStorageService
{
    public interface ILocalStorageProvider
    {
        public Task Load();

        //#region Favorits

        ///// <summary>
        ///// set favorits in localstorage
        ///// </summary>
        //public Task SetFavorits(List<Guid> productIds);

        ///// <summary>
        ///// Get favorits from localstorage
        ///// </summary>
        //public Task<List<Guid>> GetFavorits();

        ///// <summary>
        ///// Get favorits count from localstorage
        ///// </summary>
        //public int GetFavoritsCount();

        ///// <summary>
        ///// Remove favorits from localstorage
        ///// </summary>
        //public Task CleanFavorits();

        //#endregion Favorits

    }
}
