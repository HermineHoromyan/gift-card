using Grpc.Core;
using NverCard.Public.Client.Modal.ToastModal;
using System;
using System.Threading.Tasks;

namespace NverCard.Public.Client.Services.ToastService
{
    public class ToastService : IToastService
    {
        private readonly Toast toast;

        public event Action<ToastLevel, string, bool> OnShow;
        public event Action OnClose;

        public ToastService(Toast toast)
        {
            this.toast = toast;
        }

        public async Task AddFavorit()
        {
            OnShow?.Invoke(ToastLevel.Success, "Հաջողությամբ ավելացվել է ընտրվածների ցուցակում", true);
        }

        public async Task AddShoppingCartItem()
        {
            OnShow?.Invoke(ToastLevel.Success, "Հաջողությամբ ավելացվել է զամբյուղում", true);
        }

        public async Task RemoveShoppingCartItem()
        {
            OnShow?.Invoke(ToastLevel.Success, "Հաջողությամբ հեռացվել է զամբյուղից", true);
        }

        public async Task RemoveFavorit()
        {
            OnShow?.Invoke(ToastLevel.Success, "Հաջողությամբ հեռացվել է ընտրվածների ցուցակից", true);
        }

        public async Task Error(Exception exception)
        {
            var msgs = exception.Message.Split(",");
            string message = msgs[1].Replace("Detail=\"", "");
            message = message.Replace("\")", "");
            OnShow?.Invoke(ToastLevel.Error, message, true);
        }

        public async Task Error(string message)
        {            
            OnShow?.Invoke(ToastLevel.Error, message, true);
        }
    }
}
