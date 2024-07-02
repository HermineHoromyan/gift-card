//Proxy!!!!!!!!!!!!

using System.ComponentModel.DataAnnotations;

namespace NverCard.Public.Client.ServiceProxies.Dictionaries
{
    /// <summary>
    /// Статус заказа
    /// </summary>
    public enum OrderStatus
    {
        /// <summary>
        /// Ստեղծված  
        /// </summary>
        [Display(Name = "Ստեղծված")]
        [Name("Ստեղծված")]
        Created = 1,

        /// <summary>
        /// Հեռացված  
        /// </summary>
        [Display(Name = "Հեռացված")]
        [Name("Հեռացված")]
        Deleted = 2,

        /// <summary>
        /// Չեղարկված  
        /// </summary>
        [Display(Name = "Չեղարկված")]
        [Name("Չեղարկված")]
        Canceled = 3,

        /// <summary>
        /// Հավաքված  
        /// </summary>
        [Display(Name = "Հավաքված")]
        [Name("Հավաքված")]
        Assembled = 4,

        /// <summary>
        /// Ուղարկված  
        /// </summary>
        [Display(Name = "Ուղարկված")]
        [Name("Ուղարկված")]
        Sended = 5,

        /// <summary>
        /// Բեռնված  
        /// </summary>
        [Display(Name = "Բեռնված")]
        [Name("Բեռնված")]
        Downloaded = 6,

        /// <summary>
        /// Հայտ  
        /// </summary>
        [Display(Name = "Հայտ")]
        [Name("Հայտ")]
        Request = 7,

        /// <summary>
        /// Մշակված  
        /// </summary>
        [Display(Name = "Մշակված")]
        [Name("Մշակված")]
        Processed = 8,

        /// <summary>
        /// Պահեստավորած  
        /// </summary>
        [Display(Name = "Պահեստավորած")]
        [Name("Պահեստավորած")]
        Reserved = 9,

        /// <summary>
        /// Չվճարված  
        /// </summary>
        [Display(Name = "Չվճարված")]
        [Name("Չվճարված")]
        DoNotPay = 10
    }
}