#pragma checksum "D:\VS\冰岩\Database\src\DatabaseLocal\BlazorClient\Shared\SurveyPrompt.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2509aaf80c4eb7ff240ff9eb6d7deb7aa3135f54"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorClient.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "D:\VS\冰岩\Database\src\DatabaseLocal\BlazorClient\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "D:\VS\冰岩\Database\src\DatabaseLocal\BlazorClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "D:\VS\冰岩\Database\src\DatabaseLocal\BlazorClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 4 "D:\VS\冰岩\Database\src\DatabaseLocal\BlazorClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 5 "D:\VS\冰岩\Database\src\DatabaseLocal\BlazorClient\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "D:\VS\冰岩\Database\src\DatabaseLocal\BlazorClient\_Imports.razor"
using BlazorClient;

#line default
#line hidden
#line 7 "D:\VS\冰岩\Database\src\DatabaseLocal\BlazorClient\_Imports.razor"
using BlazorClient.Shared;

#line default
#line hidden
    public class SurveyPrompt : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "alert alert-secondary mt-4");
            __builder.AddAttribute(2, "role", "alert");
            __builder.AddMarkupContent(3, "\r\n    <span class=\"oi oi-pencil mr-2\" aria-hidden=\"true\"></span>\r\n    ");
            __builder.OpenElement(4, "strong");
            __builder.AddContent(5, 
#line 3 "D:\VS\冰岩\Database\src\DatabaseLocal\BlazorClient\Shared\SurveyPrompt.razor"
             Title

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n\r\n    ");
            __builder.AddMarkupContent(7, "<span class=\"text-nowrap\">\r\n        Please take our\r\n        <a target=\"_blank\" class=\"font-weight-bold\" href=\"https://go.microsoft.com/fwlink/?linkid=2100553\">brief survey</a>\r\n    </span>\r\n    and tell us what you think.\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 12 "D:\VS\冰岩\Database\src\DatabaseLocal\BlazorClient\Shared\SurveyPrompt.razor"
       
    // Demonstrates how a parent component can supply parameters
    [Parameter] public string Title { get; set; }

#line default
#line hidden
    }
}
#pragma warning restore 1591
