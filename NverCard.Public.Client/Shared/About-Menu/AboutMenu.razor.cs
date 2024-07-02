using Microsoft.AspNetCore.Components;

namespace NverCard.Public.Client.Shared.About_Menu
{
    public partial class AboutMenu
    {
        #region Parameters
        
        [Parameter]
        public bool IsCompanyInfo { get; set; } = false;

        [Parameter]
        public bool IsAbout { get; set; } = false;

        [Parameter]
        public bool IsRules { get; set; } = false;

        [Parameter]
        public bool IsOrderRules { get; set; } = false;

        [Parameter]
        public bool IsOrderPayRules { get; set; } = false;

        [Parameter]
        public bool IsCashPayRules { get; set; } = false;

        [Parameter]
        public bool IsOnlinePayRules { get; set; } = false;

        #endregion Parameters

        #region Methods

        private string GetName()
        {
            if (IsCompanyInfo)
                return "Ընկերության մասին";
            if (IsRules)
                return "Կանոններ";
            if (IsOrderRules)
                return "Պատվերի կարգը";
            if (IsOrderPayRules)
                return "Պատվերի վճարման կարգը";
            if (IsOnlinePayRules)
                return "Անկանխիկ վճարում";
            if (IsCashPayRules)
                return "Կանխիկ վճարում";


            return "Մեր մասին";
        }

        #endregion Methods
    }
}
