#pragma checksum "D:\VS\冰岩\Database\src\DatabaseLocal\BlazorClient\Pages\blog\AliceEditor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47159f4b444faaf494c76e317835ac9b332443ee"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorClient.Pages.blog
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
#line 3 "D:\VS\冰岩\Database\src\DatabaseLocal\BlazorClient\Pages\blog\AliceEditor.razor"
using dreamofalice.club.Models.Blogs;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/editor")]
    public class AliceEditor : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"offset-2\">AliceEditor</h3>\r\n");
            __builder.AddContent(1, 
#line 4 "D:\VS\冰岩\Database\src\DatabaseLocal\BlazorClient\Pages\blog\AliceEditor.razor"
 render

#line default
#line hidden
            );
            __builder.AddMarkupContent(2, "\r\n\r\n\r\n");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container border-primary");
            __builder.AddMarkupContent(5, "\r\n");
#line 8 "D:\VS\冰岩\Database\src\DatabaseLocal\BlazorClient\Pages\blog\AliceEditor.razor"
     foreach (var item in parts)
    {

#line default
#line hidden
            __builder.AddContent(6, "        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "row");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "select");
            __builder.AddAttribute(11, "class", "form-control col-4");
            __builder.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 11 "D:\VS\冰岩\Database\src\DatabaseLocal\BlazorClient\Pages\blog\AliceEditor.razor"
                                                      parts[parts.IndexOf(item)].TextType

#line default
#line hidden
            ));
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => parts[parts.IndexOf(item)].TextType = __value, parts[parts.IndexOf(item)].TextType));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(14, "\r\n");
#line 12 "D:\VS\冰岩\Database\src\DatabaseLocal\BlazorClient\Pages\blog\AliceEditor.razor"
                 foreach (var template in Enum.GetValues(typeof(textType)))
                {

#line default
#line hidden
            __builder.AddContent(15, "                    ");
            __builder.OpenElement(16, "option");
            __builder.AddAttribute(17, "value", 
#line 14 "D:\VS\冰岩\Database\src\DatabaseLocal\BlazorClient\Pages\blog\AliceEditor.razor"
                                   template

#line default
#line hidden
            );
            __builder.AddContent(18, 
#line 14 "D:\VS\冰岩\Database\src\DatabaseLocal\BlazorClient\Pages\blog\AliceEditor.razor"
                                             template

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
#line 15 "D:\VS\冰岩\Database\src\DatabaseLocal\BlazorClient\Pages\blog\AliceEditor.razor"
                }

#line default
#line hidden
            __builder.AddContent(20, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n");
#line 17 "D:\VS\冰岩\Database\src\DatabaseLocal\BlazorClient\Pages\blog\AliceEditor.razor"
             if (parts[parts.IndexOf(item)].TextType == textType.h1
|| parts[parts.IndexOf(item)].TextType == textType.h2
|| parts[parts.IndexOf(item)].TextType == textType.h3
|| parts[parts.IndexOf(item)].TextType == textType.p)
            {

#line default
#line hidden
            __builder.AddContent(22, "                ");
            __builder.OpenElement(23, "button");
            __builder.AddAttribute(24, "class", "btn-outline-dark col-1 btn");
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 22 "D:\VS\冰岩\Database\src\DatabaseLocal\BlazorClient\Pages\blog\AliceEditor.razor"
                                                                     e => ClickB(parts.IndexOf(item))

#line default
#line hidden
            ));
            __builder.AddMarkupContent(26, "\r\n                    B\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.OpenElement(28, "button");
            __builder.AddAttribute(29, "class", "btn-outline-dark col-1 btn");
            __builder.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 25 "D:\VS\冰岩\Database\src\DatabaseLocal\BlazorClient\Pages\blog\AliceEditor.razor"
                                                                     e => ClickI(parts.IndexOf(item))

#line default
#line hidden
            ));
            __builder.AddMarkupContent(31, "\r\n                    I\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n");
#line 28 "D:\VS\冰岩\Database\src\DatabaseLocal\BlazorClient\Pages\blog\AliceEditor.razor"
            }

#line default
#line hidden
            __builder.AddContent(33, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
#line 30 "D:\VS\冰岩\Database\src\DatabaseLocal\BlazorClient\Pages\blog\AliceEditor.razor"
         if (parts[parts.IndexOf(item)].TextType == textType.img)
        {

#line default
#line hidden
            __builder.AddContent(35, "            ");
            __builder.OpenElement(36, "input");
            __builder.AddAttribute(37, "id", 
#line 32 "D:\VS\冰岩\Database\src\DatabaseLocal\BlazorClient\Pages\blog\AliceEditor.razor"
                        parts.IndexOf(item)

#line default
#line hidden
            );
            __builder.AddAttribute(38, "class", "form-control row col-8");
            __builder.AddAttribute(39, "type", "file");
            __builder.AddAttribute(40, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#line 34 "D:\VS\冰岩\Database\src\DatabaseLocal\BlazorClient\Pages\blog\AliceEditor.razor"
                              Change

#line default
#line hidden
            ));
            __builder.AddAttribute(41, "accept", "image/*");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n");
#line 36 "D:\VS\冰岩\Database\src\DatabaseLocal\BlazorClient\Pages\blog\AliceEditor.razor"
        }
        else
        {

#line default
#line hidden
            __builder.AddContent(43, "            ");
            __builder.OpenElement(44, "textarea");
            __builder.AddAttribute(45, "placeholder", "拖动右下角改变大小，编辑完后点击空白处预览");
            __builder.AddAttribute(46, "id", "text" + (
#line 39 "D:\VS\冰岩\Database\src\DatabaseLocal\BlazorClient\Pages\blog\AliceEditor.razor"
                                                                    parts.IndexOf(item)

#line default
#line hidden
            ));
            __builder.AddAttribute(47, "class", "form-control row col-8");
            __builder.AddAttribute(48, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 40 "D:\VS\冰岩\Database\src\DatabaseLocal\BlazorClient\Pages\blog\AliceEditor.razor"
                             parts[parts.IndexOf(item)].InText

#line default
#line hidden
            ));
            __builder.AddAttribute(49, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => parts[parts.IndexOf(item)].InText = __value, parts[parts.IndexOf(item)].InText));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n");
#line 42 "D:\VS\冰岩\Database\src\DatabaseLocal\BlazorClient\Pages\blog\AliceEditor.razor"
        }

#line default
#line hidden
            __builder.AddContent(51, "        ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "btn-group-sm");
            __builder.AddMarkupContent(54, "\r\n            ");
            __builder.OpenElement(55, "button");
            __builder.AddAttribute(56, "class", "btn btn-sm btn-outline-primary");
            __builder.AddAttribute(57, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 44 "D:\VS\冰岩\Database\src\DatabaseLocal\BlazorClient\Pages\blog\AliceEditor.razor"
                                                                     e => Add(parts.IndexOf(item))

#line default
#line hidden
            ));
            __builder.AddContent(58, "Add");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n            ");
            __builder.OpenElement(60, "button");
            __builder.AddAttribute(61, "class", "btn btn-sm btn-outline-danger");
            __builder.AddAttribute(62, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 45 "D:\VS\冰岩\Database\src\DatabaseLocal\BlazorClient\Pages\blog\AliceEditor.razor"
                                                                    e => Delete(parts.IndexOf(item))

#line default
#line hidden
            ));
            __builder.AddContent(63, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n");
#line 47 "D:\VS\冰岩\Database\src\DatabaseLocal\BlazorClient\Pages\blog\AliceEditor.razor"
    }

#line default
#line hidden
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n\r\n\r\n\r\n\r\n");
            __builder.OpenComponent<BlazorClient.Pages.blog.AlicePreviewer>(67);
            __builder.AddAttribute(68, "stringBuilder", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Text.StringBuilder>(
#line 53 "D:\VS\冰岩\Database\src\DatabaseLocal\BlazorClient\Pages\blog\AliceEditor.razor"
                               stringBuilder

#line default
#line hidden
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(69, "\r\n");
#line 54 "D:\VS\冰岩\Database\src\DatabaseLocal\BlazorClient\Pages\blog\AliceEditor.razor"
  
    stringBuilder.Clear();
    stringBuilder.Append(JsonConvert.SerializeObject(parts));

#line default
#line hidden
            __builder.AddMarkupContent(70, "\r\n");
            __builder.OpenElement(71, "input");
            __builder.AddAttribute(72, "hidden", "hidden");
            __builder.AddAttribute(73, "name", "Content");
            __builder.AddAttribute(74, "value", 
#line 59 "D:\VS\冰岩\Database\src\DatabaseLocal\BlazorClient\Pages\blog\AliceEditor.razor"
                                               stringBuilder.ToString()

#line default
#line hidden
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 61 "D:\VS\冰岩\Database\src\DatabaseLocal\BlazorClient\Pages\blog\AliceEditor.razor"
       
    /// <summary>
    /// This component is created by Alice
    /// 2019/9/25 create
    /// </summary>
    public List<Text> parts { get; set; }
    [Parameter]
    public StringBuilder stringBuilder { get; set; }
    RenderFragment render;
    [Inject]
    IJSRuntime jSRuntime { get; set; }
    System.Security.Claims.ClaimsPrincipal claims;
    protected override void OnInitialized()
    {
        if (stringBuilder == null)
        {
            stringBuilder = new StringBuilder(10000);
        }
        else
        {
            parts = JsonConvert.DeserializeObject<List<Text>>(stringBuilder.ToString());
        }
        jSRuntime.InvokeAsync<string>("blazorJsFunctions.init");
        if (parts == null)
        {
            parts = new List<Text>() { new Text() };
        }
    }
    private void Delete(int id)
    {
        parts.RemoveAt(id);
    }
    private void Focus()
    {
        jSRuntime.InvokeAsync<string>("blazorJsFunctions.log");
    }
    private async Task ClickB(int id)
    {
        parts[id].InText += "|b此处加粗b|";
    }
    private async Task ClickI(int id)
    {
        parts[id].InText += "|i此处斜体i|";
    }
    private void Add(int id)
    {
        parts.Insert(id + 1, new Text());
    }
    private async Task Change(ChangeEventArgs args)
    {
        for (int i = 0; i < parts.Count; i++)
        {
            if (parts[i].TextType == textType.img)
            {
                try
                {
                    await jSRuntime.InvokeAsync<string>("blazorJsFunctions.getImgString", $"{i}");
                    await Task.Delay(1000);
                    parts[i].InText = await jSRuntime.InvokeAsync<string>("blazorJsFunctions.getHideString", $"{i}");
                }
                catch (Exception)
                {
                }
            }
        }
    }
    private void Render()
    {
        render = b =>
        {
            //b.OpenElement(1, "h1");

            b.AddContent(1, "Hi!");
            b.CloseElement();
        };

    }



#line default
#line hidden
    }
}
#pragma warning restore 1591
