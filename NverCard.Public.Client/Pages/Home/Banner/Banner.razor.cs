using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using NverCard.Public.Client.ServiceProxies.Queries.Contents;
using NverCard.Public.Client.ServiceProxies.Queries.Contents.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NverCard.Public.Client.Pages.Home.Banner
{
    public partial class Banner
    {
        #region Inject
        [Inject]
        GetSlidersQueryProxy GetSlidersQueryProxy { get; set; }
        [Inject]
        IJSRuntime JSRuntime { get; set; }
        #endregion Inject
        #region Properties
        private IEnumerable<SliderModel> Slider { get; set; }
        #endregion Properties

        #region Methods
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await JSRuntime.InvokeVoidAsync("swiperConfig.init");
        }
        protected override async Task OnInitializedAsync()
        {
            Slider = await GetSlidersQueryProxy.Execute();
        }
        #endregion Methods
    }
}
