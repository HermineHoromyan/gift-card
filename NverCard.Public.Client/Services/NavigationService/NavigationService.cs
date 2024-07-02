using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;

namespace NverCard.Public.Client.Services.NavigationService
{
    public class NavigationService : INavigationService
    {
        private readonly NavigationManager navigationManager;
        #region Constructor

        public NavigationService(NavigationManager navigationManager
            )
        {
            this.navigationManager = navigationManager;
        }

        #endregion Constructor

        #region Fields

        public event Action OnChange;


        #endregion Fields

        #region Properties

        public bool IsBasket { get; set; }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Get products for paging
        /// </summary>
        public async Task GoToPage(string url)
        {
            if (url == "basket" || url =="checkout")
                IsBasket = true;
            else IsBasket = false;

            OnChange?.Invoke();
            navigationManager.NavigateTo(url);
        }

        /// <summary>
        /// Get products for paging
        /// </summary>
        public async Task CheckIsBasket(string url)
        {
            if (url == "basket" || url == "checkout")
                IsBasket = true;
            else IsBasket = false;

            OnChange?.Invoke();
        }

        #endregion Methods
    }
}
