//Proxy!!!!!!!!!!!!

using System.ComponentModel.DataAnnotations;

namespace NverCard.Public.Client.ServiceProxies.Dictionaries
{

    public enum GiftCardType
    {
        /// <summary>
        /// Էլեկտրոնային
        /// </summary>
        [Display(Name = "Էլեկտրոնային")]
        Electronic = 1,

        /// <summary>
        /// Էլեկտրոնային
        /// </summary>
        [Display(Name = "Պլաստիկ")]
        Plastic = 2
    }
}