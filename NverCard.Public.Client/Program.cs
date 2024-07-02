using Blazored.LocalStorage;
using Grpc.Net.Client;
using Grpc.Net.Client.Web;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using NverCard.Public.Client.InteropServices;
using NverCard.Public.Client.Modal.ToastModal;
using NverCard.Public.Client.ServiceProxies;
using NverCard.Public.Client.Services.FavoritService;
using NverCard.Public.Client.Services.LocalStorageService;
using NverCard.Public.Client.Services.NavigationService;
using NverCard.Public.Client.Services.OrderService;
using NverCard.Public.Client.Services.ProductCategoryService;
using NverCard.Public.Client.Services.ProductService;
using NverCard.Public.Client.Services.ProductTagService;
using NverCard.Public.Client.Services.ShoppingCartService;
using NverCard.Public.Client.Services.ToastService;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace NverCard.Public.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            ConfigureServices(builder.Services, builder.HostEnvironment);

            // The port number(5001) must match the port of the gRPC server.
            //var channel = GrpcChannel.ForAddress("https://localhost:5001");
            //var client = new Executor.ExecutorClient(channel);

            await builder.Build().RunAsync();
        }

        private static void ConfigureServices(IServiceCollection services, IWebAssemblyHostEnvironment hostEnvironment)
        {
            services.AddScoped(
                sp => new HttpClient { BaseAddress = new Uri(hostEnvironment.BaseAddress) });

            // local storage
            services.AddBlazoredLocalStorage();

            //Toast
            services.AddScoped<Toast>();

            // сессия + авторизация
            services.AddScoped<UserSession>();
            services.AddScoped<AuthenticationStateProvider>(provider => provider.GetService<UserSession>());
            services.AddAuthorizationCore();

            //Interfaces
            services.AddScoped<ILocalStorageProvider, LocalStorageProvider>();
            services.AddScoped<IToastService, ToastService>();
            services.AddScoped<IFavoritService, FavoritService>();
            services.AddScoped<IShoppingCartService, ShoppingCartService>();
            services.AddScoped<IProductCategoryService, ProductCategoryService>();
            services.AddScoped<IProductTagService, ProductTagService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<INavigationService, NavigationService>();
            services.AddScoped<IOrderService, OrderService>();

            //Downloader
            services.AddScoped<Downloader>();

            // прокси для команд/запросов
            services.AddServiceProxies();

            // палач!
            services.AddScoped<ServiceProxies.Executor>(provider =>
                new ServiceProxies.Executor(provider.GetService<Executor.ExecutorClient>(),
                    provider.GetService<UserSession>()));

            // grpc
            services
                .AddGrpcClient<Executor.ExecutorClient>((services, options) =>
                {
                    options.Address = new Uri(hostEnvironment.BaseAddress);
                })
                .ConfigurePrimaryHttpMessageHandler(
                    () => new GrpcWebHandler(GrpcWebMode.GrpcWebText, new HttpClientHandler()));
        }
    }
}
