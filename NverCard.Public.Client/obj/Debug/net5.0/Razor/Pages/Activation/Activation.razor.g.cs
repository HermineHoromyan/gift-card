#pragma checksum "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\Activation\Activation.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "120bf282c44d2e3bd5a1f2f320930f9dc10aeaf1"
// <auto-generated/>
#pragma warning disable 1591
namespace NverCard.Public.Client.Pages.Activation
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/activation")]
    public partial class Activation : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<section class=""activation container""><div class=""activation-block""><h4 class=""activation-block__title"">Ակտիվացման էջ *</h4>
      <p class=""activation-block__text"">To activate your card you need to enter the 16-digit number of your Card and
         your phone number</p>
      <div class=""activation-block__list g-t-c-2 g-g-32 d-g a-i-c""><div class=""activation-block__list--inputs""><div class=""activation-block__list--inputs-main""><h6 class=""activation-block__list--inputs-main__title"">Enter 16-Digit Card #</h6>
               <input type=""number"" placeholder=""#### #### #### ####""></div>
            <div class=""activation-block__list--inputs-main activation-block__list--inputs-pin""><h6 class=""activation-block__list--inputs-main__title"">PIN կոդ</h6>
               <input type=""password"" placeholder=""****"">
               <p class=""activation-block__list--inputs-main__text"">PIN կոդը ուղարկված է նշված քարտապանի հեռախոսահամարին
               </p></div>
            <button class=""btn btn-background d-f a-i-c j-c-c"">Ակտիվացնել</button></div>
         <div class=""activation-block__list--card d-none-sm""><img src=""../assets/img/cards/card.svg"" alt=""activation-card"" class=""activation-block__list--card-img""></div></div>
      <span class=""activation-block__note"">* Text about how and when you need to activate yout gift card</span></div></section>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
