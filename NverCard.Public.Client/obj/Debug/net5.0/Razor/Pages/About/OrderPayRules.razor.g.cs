#pragma checksum "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\About\OrderPayRules.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83f4711e876642e7bfd53c04e075fedbff497aeb"
// <auto-generated/>
#pragma warning disable 1591
namespace NverCard.Public.Client.Pages.About
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
#line 3 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\About\OrderPayRules.razor"
using NverCard.Public.Client.Shared.About_Menu;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/orderpayrules")]
    public partial class OrderPayRules : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "section");
            __builder.AddAttribute(1, "class", "about account");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "container");
            __builder.AddMarkupContent(4, @"<div class=""crumb d-f a-i-c""><a href=""#"" class=""crumb-logo d-f a-i-c j-c-c d-none-xs""><img class=""crumb-logo__img"" src=""../assets/img/favicon/logo-round-light.png""></a>
            <i class=""crumb-arrow icon icon-arrow_right""></i>
            <a class=""crumb-page d-none-xs"" href=""/products"">Բոլոր քարտերը</a>
            <a class=""crumb-page d-none d-block-xs"" href=""/"">Գլխավոր</a></div>
        ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "about-block d-f");
            __builder.OpenComponent<NverCard.Public.Client.Shared.About_Menu.AboutMenu>(7);
            __builder.AddAttribute(8, "IsOrderPayRules", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 17 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Pages\About\OrderPayRules.razor"
                                          true

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "           \r\n            ");
            __builder.AddMarkupContent(10, "<div class=\"about-block__text\"><h4 class=\"about-block__text--title\">Պատվերի վճարման կարգը</h4>\r\n                <p class=\"about-block__text--info\">\r\n                    Nvercard.am-ը հանդիսանում է Հայաստանում առաջինն իր տեսակով ու\r\n                    բնույթով, այն կօգնի Ձեզ խնայել ժամանակը և\r\n                    առանց տանից դուրս գալու՝ օնլայն տարբերակով, ձեռք բերել նվեր քարտ՝ տալով սեփական ընտրության\r\n                    հնարավորություն նվեր ստացողին: Այն նաև Ձեզ է առաջարկում իր բացառիկ «Ունիվերսալ» քարտը, որը թույլ է տալիս\r\n                    մեկ քարտի միջոցով դառնալ միաժամանակ մեկ և ավելի քարտերի քարտապան: Առաջարկվող քարտերի վավերականության\r\n                    ժամկետը կախված է քարտատեսակից, սակայն այն չի կարող լինել ոչ պակաս քան 6 ամիսը: nvercard.am-ը\r\n                    համագործակցելով բազմաթիվ ընկերությունների հետ, քարտապանին տալիս է նվերի մեծ ընտրության հնարավորություն:\r\n                </p>\r\n                <p class=\"about-block__text--info\">\r\n                    Կայքի գերխնդիրն է նվերի ընտրությունը դարձնել արագ, մատչելի և\r\n                    հետաքրքիր, ինչպես նաև զարգացնել օնլայն\r\n                    գնումները, դարձնելով այն յուրաքանչյուրի համար հարմարավետ: Մեր հաճախորդները կարող են, էլեկտրոնային\r\n                    տարբերակով, նվեր քարտեր գնել անգամ մեր երկրի ամենահեռավոր կետերից:\r\n                </p>\r\n                <p class=\"about-block__text--info\">\r\n                    Իսկ կորպորատիվ հաճախորդների համար առաջարկում ենք հատո՛ւկ փաթեթներ,\r\n                    հատո՛ւկ պայմաններով:\r\n                </p>\r\n                <h4 class=\"about-block__text--title\">Քայլերի հերթականությունը</h4>\r\n                <ol class=\"about-block__text--steps\"><li class=\"about-block__text--steps-info\">1. Գրանցվել կայքում,</li>\r\n                    <li class=\"about-block__text--steps-info\">2. Լրացնել անձնական տվյալները,</li>\r\n                    <li class=\"about-block__text--steps-info\">3. Կատարել օնլայն վճարում,</li>\r\n                    <li class=\"about-block__text--steps-info\">4. Նշել առաքման տեսակը (էլեկտրոնային/առձեռն)</li></ol></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
