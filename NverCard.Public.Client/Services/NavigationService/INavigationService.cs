using System;
using System.Threading.Tasks;

namespace NverCard.Public.Client.Services.NavigationService
{
    public interface INavigationService
    {
        event Action OnChange;
        public bool IsBasket { get; set; }

        Task GoToPage(string url);

        Task CheckIsBasket(string url);
    }
}
