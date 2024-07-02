using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace NverCard.Public.Client.InteropServices
{
    public class Downloader
    {
        #region Fields

        private readonly IJSRuntime jsRuntime;

        #endregion Fields

        #region Constructor

        public Downloader(IJSRuntime jsRuntime) => this.jsRuntime = jsRuntime;

        #endregion Constructor

        #region Methods

        /// <summary>
        /// Возвращает массива байтов как скачиваемый файл
        /// </summary>
        /// <param name="bytes">массива байтов</param>
        /// <param name="filename">название файла</param>
        /// <param name="contentType">Тип контента</param>
        public async Task DownloadFileAsync(byte[] bytes, string filename, string contentType = null)
        {
            await jsRuntime.InvokeVoidAsync("downloadFromByteArray", new
            {
                ByteArray = bytes,
                FileName = filename,
                ContentType = contentType
            });
        }

        #endregion Methods
    }
}
