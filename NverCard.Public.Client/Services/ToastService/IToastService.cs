using Grpc.Core;
using System;
using System.Threading.Tasks;

namespace NverCard.Public.Client.Services.ToastService
{
    public interface IToastService
    {
        public event Action<ToastLevel, string, bool> OnShow;
        public event Action OnClose;

        public Task AddFavorit();
        public Task RemoveFavorit();
        public Task AddShoppingCartItem();
        public Task RemoveShoppingCartItem();
        public Task Error(Exception exception);
        public Task Error(string Message);
    }
}
