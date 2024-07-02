
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;


namespace NverCard.Public.Client.Modal.FeedbackModal
{
    public partial class Feedback
    {
        #region Inject
        [Inject]
        private IJSRuntime JSRuntime { get; set; }
        #endregion Inject

        #region Properties
        /// <summary>
        /// Var for Feedback Modal
        /// </summary>
        private bool displayModalFeedback = false;
        #endregion Properties

        #region Reference

   

        #endregion Reference

        public async void openModalFeedback()
        {
            this.displayModalFeedback = true;
            await JSRuntime.InvokeVoidAsync("addClassToBody");
            StateHasChanged();
        }

        public async void CloseModal()
        {
            this.displayModalFeedback = false;
            await JSRuntime.InvokeVoidAsync("removeClassFromBody");
            StateHasChanged();
        }
    }
}