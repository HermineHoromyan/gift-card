#pragma checksum "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Account-cards\Account-cards.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb0e7337297a9d520a77e165c7dcb1eb53540061"
// <auto-generated/>
#pragma warning disable 1591
namespace NverCard.Public.Client.Pages.Account_cards
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
#line 2 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Account-cards\Account-cards.razor"
using NverCard.Public.Client.Shared.Account_Menu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Account-cards\Account-cards.razor"
using NverCard.Public.Client.Modal.QrcodeModal;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/account-cards")]
    public partial class Account_cards : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Web.Extensions.Head.Title>(0);
            __builder.AddAttribute(1, "Value", "Քարտեր");
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\r\n\r\n");
            __builder.OpenElement(3, "section");
            __builder.AddAttribute(4, "class", "account");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "container d-f d-block-sm");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "account-menu");
            __builder.OpenComponent<NverCard.Public.Client.Shared.Account_Menu.AccountMenu>(9);
            __builder.AddAttribute(10, "IsAccountCards", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 10 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Account-cards\Account-cards.razor"
                                         true

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "account-block animate_show_up");
            __builder.AddMarkupContent(14, "<div class=\"account-block__title d-f\"><h4 class=\"account-block__title--text account-block__title--active\">\r\n                    Նվեր քարտեր</h4></div>\r\n            ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "order-cards");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "d-g g-t-c-2-fix g-g-32");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "dropdown");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "dropdown-select dropdown-select__border click-expand d-f a-i-c j-c-b");
            __builder.AddAttribute(23, "window-click");
            __builder.AddAttribute(24, "data-expand", "false");
            __builder.OpenElement(25, "span");
            __builder.AddAttribute(26, "class", "dropdown-select__selected");
#nullable restore
#line 22 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Account-cards\Account-cards.razor"
__builder.AddContent(27, OnlyActives ? ActiveTypeText : AllTypeText);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                            <i class=\"icon icon-arrow_down dropdown-select__arrow--black\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                        ");
            __builder.OpenElement(30, "ul");
            __builder.AddAttribute(31, "class", "dropdown-list expand-block d-none");
            __builder.OpenElement(32, "li");
            __builder.AddAttribute(33, "class", "dropdown-list__item" + " " + (
#nullable restore
#line 26 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Account-cards\Account-cards.razor"
                                                             OnlyActives ? "active" : ""

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Account-cards\Account-cards.razor"
                                                                                                       () => SelelectActiveCards(true)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(35, "Ակտիվ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                            ");
            __builder.OpenElement(37, "li");
            __builder.AddAttribute(38, "class", "dropdown-list__item" + " " + (
#nullable restore
#line 27 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Account-cards\Account-cards.razor"
                                                             OnlyActives ? "" : "active"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Account-cards\Account-cards.razor"
                                                                                                       ()=> SelelectActiveCards(false)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(40, "Բոլոր");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                    ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "dropdown");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "dropdown-select dropdown-select__border click-expand d-f a-i-c j-c-b");
            __builder.AddAttribute(46, "window-click");
            __builder.AddAttribute(47, "data-expand", "false");
            __builder.OpenElement(48, "span");
            __builder.AddAttribute(49, "class", "dropdown-select__selected");
#nullable restore
#line 34 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Account-cards\Account-cards.razor"
__builder.AddContent(50, GetMontsStringValue());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                            <i class=\"icon icon-arrow_down dropdown-select__arrow--black\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                        ");
            __builder.OpenElement(53, "ul");
            __builder.AddAttribute(54, "class", "dropdown-list expand-block d-none");
            __builder.OpenElement(55, "li");
            __builder.AddAttribute(56, "class", "dropdown-list__item" + " " + (
#nullable restore
#line 39 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Account-cards\Account-cards.razor"
                                                             Months == 1 ? "active" : ""

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(57, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Account-cards\Account-cards.razor"
                                                                                                       () => SelelectMonths(1)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(58, "Վերջին 1 ամիսը");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                            ");
            __builder.OpenElement(60, "li");
            __builder.AddAttribute(61, "class", "dropdown-list__item" + " " + (
#nullable restore
#line 40 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Account-cards\Account-cards.razor"
                                                             Months == 6 ? "active" : ""

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(62, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Account-cards\Account-cards.razor"
                                                                                                       () => SelelectMonths(6)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(63, "Վերջին 6 ամիսը");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                            ");
            __builder.OpenElement(65, "li");
            __builder.AddAttribute(66, "class", "dropdown-list__item" + " " + (
#nullable restore
#line 41 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Account-cards\Account-cards.razor"
                                                             Months == 12 ? "active" : ""

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(67, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Account-cards\Account-cards.razor"
                                                                                                        () => SelelectMonths(12)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(68, "Վերջին 12 ամիսը");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n                            ");
            __builder.OpenElement(70, "li");
            __builder.AddAttribute(71, "class", "dropdown-list__item" + " " + (
#nullable restore
#line 42 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Account-cards\Account-cards.razor"
                                                             Months == null ? "active" : ""

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(72, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Account-cards\Account-cards.razor"
                                                                                                          () => SelelectMonths(null)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(73, "Բոլորը");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                ");
            __builder.OpenElement(75, "div");
            __builder.AddAttribute(76, "class", " order-cards__block card-grid d-g g-t-c-5 g-g-32");
#nullable restore
#line 47 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Account-cards\Account-cards.razor"
                     if (GiftCertificates != null)
                    {
                        if (GiftCertificates.Count() > 0)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Account-cards\Account-cards.razor"
                             foreach (var cert in GiftCertificates)
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(77, "div");
            __builder.AddAttribute(78, "class", "card");
            __builder.OpenElement(79, "div");
            __builder.AddAttribute(80, "class", "card-link");
            __builder.OpenElement(81, "a");
            __builder.AddAttribute(82, "href", "product/" + (
#nullable restore
#line 55 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Account-cards\Account-cards.razor"
                                                          cert.ProductSeoLink

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(83, "class", "card-link__img");
            __builder.OpenElement(84, "img");
            __builder.AddAttribute(85, "src", 
#nullable restore
#line 56 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Account-cards\Account-cards.razor"
                                                       cert.ImageUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(86, "alt", "card");
            __builder.AddAttribute(87, "class", "card-link__img--main");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n                                        ");
            __builder.OpenElement(89, "div");
            __builder.AddAttribute(90, "class", "order-cards__block--info");
            __builder.OpenElement(91, "h6");
            __builder.AddAttribute(92, "class", "order-cards__block--info-name");
#nullable restore
#line 59 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Account-cards\Account-cards.razor"
__builder.AddContent(93, cert.ProductName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n                                            ");
            __builder.OpenElement(95, "p");
            __builder.AddAttribute(96, "class", "order-cards__block--info-price");
#nullable restore
#line 60 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Account-cards\Account-cards.razor"
__builder.AddContent(97, cert.Nominal);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(98, " ֏");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n                                            ");
            __builder.OpenElement(100, "span");
            __builder.AddAttribute(101, "class", "order-cards__block--info-date");
            __builder.AddMarkupContent(102, "վավեր է ");
#nullable restore
#line 61 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Account-cards\Account-cards.razor"
__builder.AddContent(103, cert.ExpirationDate);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n                                            ");
            __builder.OpenElement(105, "div");
            __builder.AddAttribute(106, "class", "order-cards__block--info-files d-f");
            __builder.OpenElement(107, "button");
            __builder.AddAttribute(108, "href", "javascript:;");
            __builder.AddAttribute(109, "target", "_blank");
            __builder.AddAttribute(110, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 63 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Account-cards\Account-cards.razor"
                                                                                                      (() => DownloadPdf(cert.Id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(111, "class", "order-cards__block--info-files__btn order-cards__block--info-files__btn--pdf d-f j-c-c a-i-c");
            __builder.AddAttribute(112, "disabled", 
#nullable restore
#line 65 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Account-cards\Account-cards.razor"
                                                                    PdfButtonLoading && LoadingItemId == cert.Id

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 67 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Account-cards\Account-cards.razor"
                                                     if (PdfButtonLoading && LoadingItemId == cert.Id)
                                                        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(113, "<i class=\"icon icon-loop\"></i>");
#nullable restore
#line 70 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Account-cards\Account-cards.razor"
                                                        }
                                                        else
                                                        {
                                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Account-cards\Account-cards.razor"
__builder.AddContent(114, PdfText);

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Account-cards\Account-cards.razor"
                                                                    ;
                                                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\r\n                                                ");
            __builder.OpenElement(116, "button");
            __builder.AddAttribute(117, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 76 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Account-cards\Account-cards.razor"
                                                                  (() => ShowBarcode(cert.Id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(118, "class", "order-cards__block--info-files__btn" + " d-f" + " j-c-c" + " a-i-c" + " icon" + " " + (
#nullable restore
#line 77 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Account-cards\Account-cards.razor"
                                                                                                                          BarcodeButtonLoading && LoadingItemId == cert.Id? "" : "icon-barcode"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(119, "disabled", 
#nullable restore
#line 78 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Account-cards\Account-cards.razor"
                                                                    BarcodeButtonLoading && LoadingItemId == cert.Id

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 79 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Account-cards\Account-cards.razor"
                                                         if (BarcodeButtonLoading && LoadingItemId == cert.Id)
                                                        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(120, "<i class=\"icon icon-loop\"></i>");
#nullable restore
#line 82 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Account-cards\Account-cards.razor"
                                                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 88 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Account-cards\Account-cards.razor"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 88 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Account-cards\Account-cards.razor"
                             
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(121, "<h4 class=\"account-block__title--text account-block__title--active\">\r\n                                Նվեր քարտեր չեն գտնվել\r\n                            </h4>");
#nullable restore
#line 95 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Account-cards\Account-cards.razor"
                        }

                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n\r\n");
            __builder.OpenComponent<NverCard.Public.Client.Modal.QrcodeModal.QrcodeModal>(123);
            __builder.AddComponentReferenceCapture(124, (__value) => {
#nullable restore
#line 105 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Account-cards\Account-cards.razor"
                   qrcodeModal = (NverCard.Public.Client.Modal.QrcodeModal.QrcodeModal)__value;

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
#pragma warning restore 1591
