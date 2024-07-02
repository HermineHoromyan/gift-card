using System;
using System.ComponentModel.DataAnnotations;

namespace NverCard.Public.Client.ServiceProxies.Dictionaries
{
    /// <summary>
    /// Статус заказа
    /// </summary>
    public enum EnvelopeType
	{
		/// <summary>
		/// Չընտրված
		/// </summary>
		[Name("Չընտրված")]
		NotSelected = 0,

		/// <summary>
		/// Ստեղծված  
		/// </summary>
		[Name("Սպիտակ")]
		White = 1,

		/// <summary>
		/// Հեռացված  
		/// </summary>
		[Name("Կանաչ")]
		Green = 2,

		/// <summary>
		/// Չեղարկված  
		/// </summary>
		[Name("Կարմիր")]
		Red = 3,

		/// <summary>
		/// Հավաքված  
		/// </summary>
		[Name("Սև")]
		Black = 4
	}
}
