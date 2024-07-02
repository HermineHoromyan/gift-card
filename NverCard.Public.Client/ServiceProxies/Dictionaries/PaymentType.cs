//Proxy!!!!!!!!!!!!

using System.ComponentModel.DataAnnotations;

namespace NverCard.Public.Client.ServiceProxies.Dictionaries
{

    public enum PaymentType
    {
        /// <summary>
        /// Չի գտնվել  
        /// </summary>
        [Name("Չի գտնվել")]
        NotFind = 0,

        /// <summary>
        /// Քարտով  
        /// </summary>
        [Name("Քարտ")]
        Card = 1,

        /// <summary>
        /// Կանխիկ  
        /// </summary>
        [Name("Կանխիկ")]
        Cash = 2,

        /// <summary>
        /// Հաշվեկշիռից  
        /// </summary>
        [Name("Հաշվեկշիռ")]
        Balance = 3
    }
}