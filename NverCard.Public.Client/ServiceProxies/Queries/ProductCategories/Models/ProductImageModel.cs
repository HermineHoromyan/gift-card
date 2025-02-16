// AUTOGENERATED!!!!!!!!!!!!

using System;

namespace NverCard.Public.Client.ServiceProxies.Queries.ProductCategories.Models
{

    public partial class ProductImageModel
    {
        /// <summary>
        /// Уникальный идентификатор (primary key)
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Порядковый номер
        /// </summary>
        public int OrderIndex { get; set; }

        /// <summary>
        /// Является основным изображением?
        /// </summary>
        public bool IsMainImage { get; set; }

        /// <summary>
        /// Id файла
        /// </summary>
        public Guid FileId { get; set; }

        /// <summary>
        /// File data
        /// </summary>
        public Byte[] Data { get; set; }

        /// <summary>
        /// File name
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// File extension
        /// </summary>
        public string Extension { get; set; }

        /// <summary>
        /// image url
        /// </summary>
        public string ImageUrl { get; set; }
    }
}