#pragma checksum "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\App.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fcbd3a28428ff637426574afeb7ba595479df18f"
// <auto-generated/>
#pragma warning disable 1591
namespace NverCard.Public.Client
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
    public partial class App : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.CascadingAuthenticationState>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.Router>(2);
                __builder2.AddAttribute(3, "AppAssembly", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Reflection.Assembly>(
#nullable restore
#line 2 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\App.razor"
                          typeof(Program).Assembly

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(4, "PreferExactMatches", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 2 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\App.razor"
                                                                         true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(5, "Found", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.RouteData>)((routeData) => (__builder3) => {
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.RouteView>(6);
                    __builder3.AddAttribute(7, "RouteData", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.RouteData>(
#nullable restore
#line 4 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\App.razor"
                                   routeData

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(8, "DefaultLayout", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 4 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\App.razor"
                                                              typeof(MainLayout)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.AddAttribute(9, "NotFound", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.LayoutView>(10);
                    __builder3.AddAttribute(11, "Layout", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 7 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\App.razor"
                                 typeof(MainLayout)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(13, @"<div class="" animate_show_up""><section class=""empty""><div class=""empty-block d-f j-c-c a-i-c f-d-c""><div class=""empty-block__img""><img src=""./assets/img/empty/not_found.png"" alt=""empty""></div>
                            <div class=""empty-block__button""><a href=""#"" class=""btn button btn-background empty-block__button--btn"">Գլխավոր</a></div></div></section></div>");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
