#pragma checksum "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Modal\FeedbackModal\Feedback.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1d82b17289ef5490f0c1edd6caefb94b9b9dcbf"
// <auto-generated/>
#pragma warning disable 1591
namespace NverCard.Public.Client.Modal.FeedbackModal
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
    public partial class Feedback : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Modal\FeedbackModal\Feedback.razor"
 if (displayModalFeedback)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "modal");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "modal-backdrop");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 4 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Modal\FeedbackModal\Feedback.razor"
                                          CloseModal

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "modal-dialog d-f a-i-c j-c-c animate_show_down");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "feedback modal-content");
            __builder.OpenElement(10, "i");
            __builder.AddAttribute(11, "class", "icon icon-close modal-close");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Modal\FeedbackModal\Feedback.razor"
                                                             CloseModal

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n            ");
            __builder.AddMarkupContent(14, "<div class=\"feedback-modal\"><h2 class=\"feedback-modal__title\">Հետադարձ կապ</h2>\r\n                <div class=\"feedback-modal__content\"><div class=\"feedback-modal__content--form\"><p class=\"feedback-modal__content--form-title\">Հեռախոսահամար</p>\r\n                        <div class=\"feedback-modal__content--form-box\"><span class=\'feedback-modal__content--form-box__number\'>+374</span>\r\n                            <input type=\"tel\" name=\"phone\" data-phone-mask class=\'feedback-modal__content--form__input feedback-modal__content--form-box__input\' placeholder=\"(_ _) _ _ - _ _ - _ _ \" autocomplete=\"off\"></div></div>\r\n                    <div class=\"feedback-modal__content--form\"><p class=\"feedback-modal__content--form-title\">Էլ. հասցե</p>\r\n                        <input type=\"email\" name=\"email\" placeholder=\"inf@nvercard.am\" autocomplete=\"off\"></div>\r\n                    <div class=\"checkout-block__details--info-main__inputs\"><p class=\"feedback-modal__content--form-title\">Նշումներ (ըստ ցանկության)</p>\r\n                        <textarea id=\"textarea\" cols=\"30\" rows=\"10\" placeholder=\"Նշումներ\" class=\"checkout-block__details--info-main__inputs--textarea\"></textarea></div>\r\n                    <div class=\"feedback-modal__content--form-rules d-f a_i_s\"><label class=\"checked d-f\"><input class=\"checkbox\" type=\"checkbox\" hidden>\r\n                            <i class=\"checked-checkbox d-f a-i-c j-c-c\"></i></label>\r\n                        <p class=\"feedback-modal__content--form-rules__text\">\r\n                            Ես համաձայն եմ\r\n                            <a href=\"javascript:;\" target=\"_blank\" class=\"feedback-modal__content--form-rules__text--link\">\r\n                                Օգտվելու կանոններին\r\n                            </a> և\r\n                            <a href=\"javascript:;\" target=\"_blank\" class=\"feedback-modal__content--form-rules__text--link\">\r\n                                Գաղտնիության քաղաքականությանը\r\n                            </a></p></div>\r\n                    <button class=\"btn btn-background d-f a-i-c j-c-c\">ՈՒղարկել</button></div></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 52 "C:\Users\hermine\Desktop\nvercard\NverCard.Public.Client\Modal\FeedbackModal\Feedback.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
