using Microsoft.AspNetCore.Components;
using NverCard.Public.Client.Services.NavigationService;

namespace NverCard.Public.Client.Shared.Header
{
    public partial class Header
    {
        #region Properties

        [Inject]
        private INavigationService NavigationService { get; set; }

        #endregion Properties
    }
}
