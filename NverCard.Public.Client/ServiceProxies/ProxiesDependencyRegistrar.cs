// AUTOGENERATED!!!!!!!!!!!!

using Microsoft.Extensions.DependencyInjection;

namespace NverCard.Public.Client.ServiceProxies
{
    public static class ProxiesDependencyRegistrar
    {
        public static IServiceCollection AddServiceProxies(this IServiceCollection services)
        {
            services.AddScoped<Commands.Authenticators.CheckIsTokenConfirmationAvailableCommandProxy>();
            services.AddScoped<Commands.Authenticators.CheckValidConfirmTokenCommandProxy>();
            services.AddScoped<Commands.Authenticators.CreateAuthenticatorCommandProxy>();
            services.AddScoped<Commands.CustomerOrderItems.CreateCustomerOrderItemCommandProxy>();
            services.AddScoped<Commands.CustomerOrders.CreateCustomerOrderCommandProxy>();
            services.AddScoped<Commands.CustomerOrders.UpdateCustomerOrderCommandProxy>();
            services.AddScoped<Commands.Favorits.CreateFavoriteCommandProxy>();
            services.AddScoped<Commands.Favorits.CreateFavoriteForCustomerCommandProxy>();
            services.AddScoped<Commands.Favorits.CreateFavoritesCommandProxy>();
            services.AddScoped<Commands.Favorits.CreateOrRemoveFavoriteCommandProxy>();
            services.AddScoped<Commands.Favorits.RemoveFavoriteByProductIdCommandProxy>();
            services.AddScoped<Commands.Favorits.RemoveFavoriteCommandProxy>();
            services.AddScoped<Commands.Favorits.RemoveShoppingCartItemCommandProxy>();
            services.AddScoped<Commands.IndividualCustomers.CreateAnonymCustomerCommandProxy>();
            services.AddScoped<Commands.IndividualCustomers.CreateIndividualCustomerCommandProxy>();
            services.AddScoped<Commands.IndividualCustomers.UpdateIndividualCustomerCommandProxy>();
            services.AddScoped<Commands.ShoppingCarts.CreateShoppingCartCommandProxy>();
            services.AddScoped<Commands.ShoppingCarts.CreateShoppingCartForCustomerCommandProxy>();
            services.AddScoped<Commands.ShoppingCarts.CreateShoppingCartItemCommandProxy>();
            services.AddScoped<Commands.ShoppingCarts.CreateShoppingCartItemsForCustomerCommandProxy>();
            services.AddScoped<Commands.ShoppingCarts.UpdateShoppingCartItemCommandProxy>();
            services.AddScoped<Queries.Contents.GetSlidersQueryProxy>();
            services.AddScoped<Queries.CustomerOrders.GetCustomerOrdersQueryProxy>();
            services.AddScoped<Queries.Favorits.GetCustomerFavoritsCountQueryProxy>();
            services.AddScoped<Queries.Favorits.GetCustomerFavoritsQueryProxy>();
            services.AddScoped<Queries.GiftCertificates.GetCustomerGiftCertificateBarCodeQueryProxy>();
            services.AddScoped<Queries.GiftCertificates.GetCustomerGiftCertificatePdfCommandProxy>();
            services.AddScoped<Queries.GiftCertificates.GetCustomerGiftCertificatesQueryProxy>();
            services.AddScoped<Queries.IndividualCustomers.GetCurrentIndividualCustomerQueryProxy>();
            services.AddScoped<Queries.IndividualCustomers.GetIndividualCustomersQueryProxy>();
            services.AddScoped<Queries.ProductCategories.GetAvailableProductCategoriesQueryProxy>();
            services.AddScoped<Queries.ProductCategories.GetProductCategoriesBySeoLinkQueryProxy>();
            services.AddScoped<Queries.ProductCategories.GetProductCategoriesForParentQueryProxy>();
            services.AddScoped<Queries.ProductCategories.GetProductCategoriesQueryProxy>();
            services.AddScoped<Queries.ProductCategories.GetProductCategoryNameBySeoLinkQueryProxy>();
            services.AddScoped<Queries.Products.GetAvailableProductsShortInfoByIdsQueryProxy>();
            services.AddScoped<Queries.Products.GetAvailableProductsShortInfoQueryProxy>();
            services.AddScoped<Queries.Products.GetCustomerFavoritProductsShortInfoQueryProxy>();
            services.AddScoped<Queries.Products.GetProductByProductSeoLinkQueryProxy>();
            services.AddScoped<Queries.Products.GetProductOffersQueryProxy>();
            services.AddScoped<Queries.Products.GetProductsPageShortInfoBySeoLinkQueryProxy>();
            services.AddScoped<Queries.Products.GetProductsShortInfoByCategorySeoQueryProxy>();
            services.AddScoped<Queries.Products.GetProductsShortInfoByProductTagSeoQueryProxy>();
            services.AddScoped<Queries.Products.GetProductTagsQueryProxy>();
            services.AddScoped<Queries.ProductTags.GetAvailableProductTagsQueryProxy>();
            services.AddScoped<Queries.ProductTags.GetProductTagNameBySeoQueryProxy>();
            services.AddScoped<Queries.ProductTags.GetProductTagsSelectQueryProxy>();
            services.AddScoped<Queries.ProductToProductTagLinks.GetProductToProductTagLinksSelectQueryProxy>();
            services.AddScoped<Queries.ShoppingCarts.GetCustomerShoppingCartItemsCountQueryProxy>();
            services.AddScoped<Queries.ShoppingCarts.GetCustomerShoppingCartQueryProxy>();
            services.AddScoped<Queries.ShoppingCarts.GetShoppingCartItemsAmountQueryProxy>();

            return services;
        }
    }
}