#pragma checksum "D:\VS\冰岩\Database\src\DatabaseLocal\BlazorClient\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6dc79da2b37716d4f05dd94f0483752f9fe995cb"
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
#line 8 "D:\VS\冰岩\Database\src\DatabaseLocal\BlazorClient\_Imports.razor"
using dreamofalice.club.Models.Blogs;

#line default
#line hidden
#line 9 "D:\VS\冰岩\Database\src\DatabaseLocal\BlazorClient\_Imports.razor"
using System.Text;

#line default
#line hidden
#line 10 "D:\VS\冰岩\Database\src\DatabaseLocal\BlazorClient\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#line 11 "D:\VS\冰岩\Database\src\DatabaseLocal\BlazorClient\_Imports.razor"
using System.IO;

#line default
#line hidden
    public class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link href=\"~/css/blazorClient.css\" rel=\"stylesheet\">\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "sidebar");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenComponent<BlazorClient.Shared.NavMenu>(4);
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n\r\n");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "main");
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.AddMarkupContent(10, "<div class=\"top-row px-4\">\r\n        <a href=\"http://blazor.net\" target=\"_blank\" class=\"ml-md-auto\">About</a>\r\n    </div>\r\n\r\n    ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "content px-4");
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.AddContent(14, 
#line 13 "D:\VS\冰岩\Database\src\DatabaseLocal\BlazorClient\Shared\MainLayout.razor"
         Body

#line default
#line hidden
            );
            __builder.AddMarkupContent(15, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
