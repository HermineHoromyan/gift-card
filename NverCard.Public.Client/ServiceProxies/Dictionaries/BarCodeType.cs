//Proxy!!!!!!!!!!!!

using System.ComponentModel.DataAnnotations;

namespace NverCard.Public.Client.ServiceProxies.Dictionaries
{
    /// <summary>
    /// Тип штрихкода
    /// </summary>
    public enum BarCodeType
    {
        /// <summary>
        /// Code39
        /// </summary>
        [Display(Name = "Code39")]
        Code39 = 1,

        /// <summary>
        /// Code128
        /// </summary>
        [Display(Name = "Code128")]
        Code128 = 2,

        /// <summary>
        /// Codabar 
        /// </summary>
        [Display(Name = "Codabar")]
        Codabar = 3,

        /// <summary>
        /// Ean_13
        /// </summary>
        [Display(Name = "EAN13")]
        EAN13 = 4,

        /// <summary>
        /// EANSUPP
        /// </summary>
        [Display(Name = "EANSUPP")]
        Eansupp = 5,

        /// <summary>
        /// Inter25
        /// </summary>
        [Display(Name = "Inter25")]
        Inter25 = 6,

        /// <summary>
        /// Postnet 
        /// </summary>
        [Display(Name = "Postnet")]
        Postnet = 7,

        /// <summary>
        /// IM 
        /// </summary>
        [Display(Name = "IM")]
        Im = 8,

        /// <summary>
        /// QRCode
        /// </summary>
        [Display(Name = "QRCode")]
        QRCode = 9,

        /// <summary>
        /// Type128
        /// </summary>
        [Display(Name = "Type128")]
        Type128 = 10,

        /// <summary>
        /// Empty
        /// </summary>
        [Display(Name = "None")]
        None = 11
    }
}