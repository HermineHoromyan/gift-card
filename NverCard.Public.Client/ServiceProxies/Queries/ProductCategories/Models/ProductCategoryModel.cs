// AUTOGENERATED!!!!!!!!!!!!

using System;
using System.Collections.Generic;

namespace NverCard.Public.Client.ServiceProxies.Queries.ProductCategories.Models
{
    /// <summary>
    /// Модель просмотра категории продукта
    /// </summary>
    public partial class ProductCategoryModel
    {
        /// <summary>
        /// Уникальный идентификатор (primary key)
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Название категории 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Код иконки категории
        /// </summary>
        public string IconCode { get; set; }

        /// <summary>
        /// Ссылка SEO
        /// </summary>
        public string SeoLink { get; set; }

        /// <summary>
        /// Позиция
        /// </summary>
        public int OrderIndex { get; set; }

        /// <summary>
        /// Название родительской категория
        /// </summary>
        public string ParentCategoryName { get; set; }

        /// <summary>
        /// Уникальный идентификатор родительской категории (primary key)
        /// </summary>
        public Guid? ParentCategoryId { get; set; }

        /// <summary>
        /// Products model
        /// </summary>
        public IEnumerable<ProductShortViewModel> CategoryProducts { get; set; }
    }
}