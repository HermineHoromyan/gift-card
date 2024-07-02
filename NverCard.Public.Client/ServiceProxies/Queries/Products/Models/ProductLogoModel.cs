﻿//proxy
using System;

namespace NverCard.Public.Client.ServiceProxies.Queries.Products.Models
{
    public class ProductLogoModel
    {
        /// <summary>
        /// Id
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Название файла
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Расширение
        /// </summary>
        public string Extension { get; set; }

        /// <summary>
        /// Данные
        /// </summary>
        public byte[] Data { get; set; }
    }
}
