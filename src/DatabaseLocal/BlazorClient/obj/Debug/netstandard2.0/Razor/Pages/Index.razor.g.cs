#pragma checksum "D:\VS\冰岩\Database\src\DatabaseLocal\BlazorClient\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "faf14045db47151e215a9fddf3e470c1b3539d04"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorClient.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\r\n\r\nWelcome to your new app.\r\n\r\n");
            __builder.OpenComponent<BlazorClient.Shared.SurveyPrompt>(1);
            __builder.AddAttribute(2, "Title", "How is Blazor working for you?");
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
