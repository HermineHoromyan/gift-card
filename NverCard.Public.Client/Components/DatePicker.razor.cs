using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace NverCard.Public.Client.Components
{
    public partial class DatePicker : IDisposable
    {
        #region Inject

        [Inject] private IJSRuntime JSRuntime { get; set; }

        #endregion Inject

        #region Params

        /// <summary>
        /// Id пикера
        /// </summary>
        [Parameter]
        public string Id { get; set; }

        /// <summary>
        /// Class пикера
        /// </summary>
        [Parameter]
        public string Class { get; set; }

        /// <summary>
        /// Placeholder пикера
        /// </summary>
        [Parameter]
        public string Placeholder { get; set; }

        /// <summary>
        /// Минимальная доступная дата
        /// </summary>
        [Parameter]
        public DateTime? MinDate { get; set; }

        /// <summary>
        /// Максимальная доступная дата
        /// </summary>
        [Parameter]
        public DateTime? MaxDate { get; set; }

        /// <summary>
        /// Выбранная дата
        /// </summary>
        [Parameter]
        public DateTime? SelectedDate { get; set; }

        /// <summary>
        /// Событие изменения выбранной даты
        /// </summary>
        [Parameter]
        public EventCallback<DateTime> SelectedDateChanged { get; set; }

        #endregion Params

        private DotNetObjectReference<DatePicker> objRef;

        protected override void OnAfterRender(bool firstRender)
        {
            if (firstRender)
            {
                objRef = DotNetObjectReference.Create(this);
                JSRuntime.InvokeVoidAsync("datePicker.init", objRef, Id, MinDate, MaxDate);
            }

        }

        [JSInvokable]
        public async Task SetDate(string date)
        {
            SelectedDate = DateTime.Parse(date);
            await SelectedDateChanged.InvokeAsync(SelectedDate.Value);
        }

        public void Dispose()
        {
            objRef?.Dispose();
        }
    }
}