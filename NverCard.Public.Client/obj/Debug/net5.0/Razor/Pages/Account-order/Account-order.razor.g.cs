#pragma checksum "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Account-order\Account-order.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d85199d23077381d09aa688b5c246c41dc735226"
// <auto-generated/>
#pragma warning disable 1591
namespace NverCard.Public.Client.Pages.Account_order
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\_Imports.razor"
using NverCard.Public.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\_Imports.razor"
using NverCard.Public.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\_Imports.razor"
using NverCard.Public.Client.Shared.Navbar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\_Imports.razor"
using NverCard.Public.Client.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Extensions.Head;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\_Imports.razor"
using NverCard.Public.Client.Modal.ToastModal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\_Imports.razor"
using NverCard.Public.Client.Modal.LoginModal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\_Imports.razor"
using NverCard.Public.Client.Services.FavoritService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\_Imports.razor"
using NverCard.Public.Client.Services.LocalStorageService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\_Imports.razor"
using NverCard.Public.Client.Services.ToastService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\_Imports.razor"
using NverCard.Public.Client.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Account-order\Account-order.razor"
using NverCard.Public.Client.Shared.Account_Menu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Account-order\Account-order.razor"
using ServiceProxies.Dictionaries;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/account-order")]
    public partial class Account_order : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Web.Extensions.Head.Title>(0);
            __builder.AddAttribute(1, "Value", "Իմ պատվերները");
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(3);
            __builder.AddAttribute(4, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(5, "section");
                __builder2.AddAttribute(6, "class", "account");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "container d-f d-block-sm");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "account-menu");
                __builder2.OpenComponent<NverCard.Public.Client.Shared.Account_Menu.AccountMenu>(11);
                __builder2.AddAttribute(12, "IsAccountOrders", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 13 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Account-order\Account-order.razor"
                                                  true

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(13, "\r\n                ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "account-block animate_show_up");
                __builder2.AddMarkupContent(16, "<div class=\"account-block__title d-f\"><h4 class=\"account-block__title--text account-block__title--active\">\r\n                            Պատվերներ (2)\r\n                        </h4></div>\r\n                    ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "orders-mobile d-none d-block-xs");
                __builder2.OpenElement(19, "table");
                __builder2.AddAttribute(20, "class", "order-mobile__table");
#nullable restore
#line 23 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Account-order\Account-order.razor"
                             if (CustomerOrders != null)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Account-order\Account-order.razor"
                                 foreach (var order in CustomerOrders)
                                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(21, "tr");
                __builder2.AddAttribute(22, "class", "orders-mobile__table--list" + " " + (
#nullable restore
#line 27 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Account-order\Account-order.razor"
                                                                            @order.Status != OrderStatus.Assembled ? "disabled" : ""

#line default
#line hidden
#nullable disable
                ));
                __builder2.OpenElement(23, "td");
                __builder2.AddAttribute(24, "class", "orders-mobile__table--list-info");
                __builder2.OpenElement(25, "p");
                __builder2.AddAttribute(26, "class", "orders-mobile__table--list-info__regular");
#nullable restore
#line 29 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Account-order\Account-order.razor"
__builder2.AddContent(27, order.OrderRequestDateTime);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n                                            ");
                __builder2.OpenElement(29, "span");
                __builder2.AddAttribute(30, "class", "orders-mobile__table--list-info__regular");
                __builder2.AddContent(31, "N ");
#nullable restore
#line 30 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Account-order\Account-order.razor"
__builder2.AddContent(32, order.Number);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n                                        ");
                __builder2.OpenElement(34, "td");
                __builder2.AddAttribute(35, "class", "orders-mobile__table--list-info");
                __builder2.OpenElement(36, "p");
                __builder2.AddAttribute(37, "class", "orders-mobile__table--list-info__regular");
#nullable restore
#line 33 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Account-order\Account-order.razor"
__builder2.AddContent(38, order.CertificatesCount);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n                                        ");
                __builder2.OpenElement(40, "td");
                __builder2.AddAttribute(41, "class", "orders-mobile__table--list-info");
                __builder2.OpenElement(42, "p");
                __builder2.AddAttribute(43, "class", "orders-mobile__table--list-info__regular");
#nullable restore
#line 36 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Account-order\Account-order.razor"
__builder2.AddContent(44, order.OrderStatusName);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n                                            ");
                __builder2.OpenElement(46, "span");
                __builder2.AddAttribute(47, "class", "orders-mobile__table--list-info__bold");
#nullable restore
#line 37 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Account-order\Account-order.razor"
__builder2.AddContent(48, order.TotalPrice);

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(49, " ֏");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 40 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Account-order\Account-order.razor"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Account-order\Account-order.razor"
                                 
                            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n                    ");
                __builder2.OpenElement(51, "div");
                __builder2.AddAttribute(52, "class", "block-orders scrollbar d-none-xs");
                __builder2.OpenElement(53, "table");
                __builder2.AddAttribute(54, "class", "block-orders__table");
                __builder2.AddMarkupContent(55, @"<tr class=""block-orders__table--title""><th class=""block-orders__table--title-single"">Ամսաթիվ</th>
                                <th class=""block-orders__table--title-single"">Պատվերի N</th>
                                <th class=""block-orders__table--title-single"">Քարտերի քանակ</th>
                                <th class=""block-orders__table--title-single"">Գումար</th>
                                <th class=""block-orders__table--title-single"">Կարգավիճակ</th></tr>");
#nullable restore
#line 53 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Account-order\Account-order.razor"
                             if (CustomerOrders != null)
                            {
                                

#line default
#line hidden
#nullable disable
                __Blazor.NverCard.Public.Client.Pages.Account_order.Account_order.TypeInference.CreateVirtualize_0(__builder2, 56, 57, 
#nullable restore
#line 57 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Account-order\Account-order.razor"
                                                   CustomerOrders.ToList()

#line default
#line hidden
#nullable disable
                , 58, (order) => (__builder3) => {
                    __builder3.OpenElement(59, "tr");
                    __builder3.AddAttribute(60, "class", "block-orders__table--list" + " " + (
#nullable restore
#line 58 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Account-order\Account-order.razor"
                                                                           @order.Status != OrderStatus.Assembled ? "disabled" : ""

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.OpenElement(61, "td");
                    __builder3.AddAttribute(62, "class", "block-orders__table--list-info");
#nullable restore
#line 59 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Account-order\Account-order.razor"
__builder3.AddContent(63, order.OrderRequestDateTime);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(64, "\r\n                                        ");
                    __builder3.OpenElement(65, "td");
                    __builder3.AddAttribute(66, "class", "block-orders__table--list-info");
                    __builder3.AddContent(67, "N ");
#nullable restore
#line 60 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Account-order\Account-order.razor"
__builder3.AddContent(68, order.Number);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(69, "\r\n                                        ");
                    __builder3.OpenElement(70, "td");
                    __builder3.AddAttribute(71, "class", "block-orders__table--list-info");
#nullable restore
#line 61 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Account-order\Account-order.razor"
__builder3.AddContent(72, order.CertificatesCount);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(73, "\r\n                                        ");
                    __builder3.OpenElement(74, "td");
                    __builder3.AddAttribute(75, "class", "block-orders__table--list-info block-orders__table--list-bold");
#nullable restore
#line 63 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Account-order\Account-order.razor"
__builder3.AddContent(76, order.TotalPrice);

#line default
#line hidden
#nullable disable
                    __builder3.AddMarkupContent(77, " ֏\r\n                                        ");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(78, "\r\n                                        ");
                    __builder3.OpenElement(79, "td");
                    __builder3.AddAttribute(80, "class", "block-orders__table--list-info");
#nullable restore
#line 65 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Account-order\Account-order.razor"
__builder3.AddContent(81, order.OrderStatusName);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                }
                );
#nullable restore
#line 68 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Account-order\Account-order.razor"
                                //}
                            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(82, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(83, @"<div class=""animate_show_up""><section class=""empty""><div class=""empty-block d-f j-c-c a-i-c f-d-c""><div class=""empty-block__img""><img src=""./assets/img/empty/empty_wishlist.png"" alt=""empty""></div>
                    <div class=""empty-block__button""><a href=""#"" class=""btn button btn-background empty-block__button--btn"">Գլխավոր</a></div></div></section></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(84, "\r\n\r\n");
            __builder.OpenComponent<NverCard.Public.Client.Modal.LoginModal.Login>(85);
            __builder.AddComponentReferenceCapture(86, (__value) => {
#nullable restore
#line 92 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Account-order\Account-order.razor"
             modalLogin = (NverCard.Public.Client.Modal.LoginModal.Login)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.NverCard.Public.Client.Pages.Account_order.Account_order
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateVirtualize_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.ICollection<TItem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment<TItem> __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Web.Virtualization.Virtualize<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
