#pragma checksum "D:\VS\冰岩\Database\src\DatabaseLocal\BlazorClient\Pages\BlazorHttpClient.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba3f84db60804b9097c5e1a4dc2854ccdb9eedef"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "D:\VS\冰岩\Database\src\DatabaseLocal\BlazorClient\Pages\BlazorHttpClient.razor"
using ClientShared;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/client")]
    public class BlazorHttpClient : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 43 "D:\VS\冰岩\Database\src\DatabaseLocal\BlazorClient\Pages\BlazorHttpClient.razor"
       
    int currentCount = 0;
    List<string> logs;
    Client client;
    bool addVal;
    string s;
    string addS;
    string icon;
    protected override void OnInitialized()
    {
        client = new Client();
        logs = new List<string>();
        addVal = false;
    }
    async Task AddKey()
    {
        addVal = true;
        addS = $"set {s} ";
        s = "";
    }
    async Task AddVal()
    {
        addVal = false;
        addS = addS + s;
        logs.Add(addS);
        var re = await client.PostAsync(addS);
        logs.Add("response" + re);
    }
    async Task Delete()
    {
        logs.Add($"delete {s}");
        var re = await client.PostAsync(logs.LastOrDefault());
        logs.Add("response" + re);
    }
    async Task Select()
    {
        logs.Add($"get {s}");
        var re = await client.PostAsync(logs.LastOrDefault());
        if (re == null || re == "")
        {
            logs.Add("Nothing Found!");
        }
        else
        {
            logs.Add("response:" + re);
        }
    }
    async Task SetUri(ChangeEventArgs args)
    {
        client.SetUri(args.Value.ToString());
        try
        {
            await client.TestConnection();
            icon = "oi-check";
        }
        catch (Exception)
        {

            icon = "oi-x";
        }
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
