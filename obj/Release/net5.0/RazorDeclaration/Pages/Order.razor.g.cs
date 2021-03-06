// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace PDF_Portal_Azure_AD.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "Z:\PDF_WebSite\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "Z:\PDF_WebSite\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "Z:\PDF_WebSite\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "Z:\PDF_WebSite\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "Z:\PDF_WebSite\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "Z:\PDF_WebSite\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "Z:\PDF_WebSite\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "Z:\PDF_WebSite\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "Z:\PDF_WebSite\_Imports.razor"
using PDF_Portal_Azure_AD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "Z:\PDF_WebSite\_Imports.razor"
using PDF_Portal_Azure_AD.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "Z:\PDF_WebSite\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "Z:\PDF_WebSite\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "Z:\PDF_WebSite\_Imports.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "Z:\PDF_WebSite\_Imports.razor"
using System.IdentityModel.Tokens.Jwt;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "Z:\PDF_WebSite\_Imports.razor"
using Microsoft.IdentityModel.Tokens;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "Z:\PDF_WebSite\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "Z:\PDF_WebSite\_Imports.razor"
using PDF_Portal_Azure_AD.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "Z:\PDF_WebSite\_Imports.razor"
using PDF_Portal_Azure_AD.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "Z:\PDF_WebSite\_Imports.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "Z:\PDF_WebSite\Pages\Order.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/view/orders/{FK_Father}")]
    public partial class Order : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "Z:\PDF_WebSite\Pages\Order.razor"
 
    [Parameter]
    public string FK_Father { get; set; }

    public List<GenericFF_Model> orders = null;
    public string searchString = "";
    string goback = "/";


    protected async override Task OnInitializedAsync()
    {
        FK_Father = Uri.EscapeDataString(FK_Father);
        orders = await httpClient.GetFromJsonAsync<List<GenericFF_Model>>(@"https://localhost:44315/api/Views/orders?father_name=" + CustomProtection.Encode(FK_Father));

    }

    private void clicked(string folder_name)
    {
        NavigationManager.NavigateTo("view/suborder/" + CustomProtection.Decode(folder_name));
    }

    private bool FilterFunc(GenericFF_Model element)
    {
        if (string.IsNullOrWhiteSpace(searchString))
            return true;
        if (element.FF_Name.Contains(searchString, StringComparison.OrdinalIgnoreCase))
            return true;
        if ($"{element.Location_path} {element.FK_Father} ".Contains(searchString))
            return true;
        return false;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CustomIDataProtection CustomProtection { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient httpClient { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
