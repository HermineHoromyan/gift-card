#pragma checksum "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Home\NewCategory\NewCategory.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47886b15834177ee0c8dd2fa5129dd2d2374b68a"
// <auto-generated/>
#pragma warning disable 1591
namespace NverCard.Public.Client.Pages.Home.NewCategory
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
    public partial class NewCategory : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Home\NewCategory\NewCategory.razor"
 if (NewArrivalsProducts != null && NewArrivalsProducts.Count() > 0)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "section");
            __builder.AddAttribute(1, "class", "section-block");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "container");
            __builder.AddMarkupContent(4, "<h2 class=\"section-block__list--title\">Նորույթ</h2>\r\n            ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "section-block__list--slide swiper");
            __builder.AddAttribute(7, "category-slider");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "swiper-wrapper");
#nullable restore
#line 8 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Home\NewCategory\NewCategory.razor"
                     foreach (var product in NewArrivalsProducts)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "a");
            __builder.AddAttribute(11, "class", "swiper-slide card-link");
            __builder.AddAttribute(12, "href", "/product/" + (
#nullable restore
#line 10 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Home\NewCategory\NewCategory.razor"
                                                                          product.ProductSeoLink

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(13, "img");
            __builder.AddAttribute(14, "src", 
#nullable restore
#line 11 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Home\NewCategory\NewCategory.razor"
                                       product.ProductImage.ImageUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(15, "alt", "category");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 13 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Home\NewCategory\NewCategory.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                <div class=\"swiper-pagination\"></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 19 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Home\NewCategory\NewCategory.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
