//Proxy!!!!!!!!!!!!

using System.ComponentModel.DataAnnotations;
using System;

namespace NverCard.Public.Client.ServiceProxies.Dictionaries
{

    public enum Currency
    {
        /// <summary>
        /// AMD
        /// </summary>
        [Display(Name = "AMD")]
        [Value("֏")]
        AMD = 1,

        /// <summary>
        /// RUR
        /// </summary>
        [Display(Name = "RUR")]
        [Value("₽")]
        RUR = 2,

        /// <summary>
        /// USD
        /// </summary>
        [Display(Name = "USD")]
        [Value("$")]
        USD = 3
    }
    public class ValueAttribute : Attribute
    {
        public ValueAttribute(string value)
        {
            Value = value;
        }
        public string Value { get; }
    }
}