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
#line 2 "Z:\PDF_WebSite\Pages\Clients.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/clients/")]
    public partial class Clients : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "Z:\PDF_WebSite\Pages\Clients.razor"
       
    [Parameter]
    public string Table_Name { get; set; }

    [Parameter]
    public string FK_Father { get; set; } = "Commesse";

    [CascadingParameter]
    private Task<AuthenticationState> AuthenticationStateTask { get; set; }

    // Public var
    public List<GenericFF_Model> TableModel = new();
    public string InfoMessage { get; set; }
    public string searchString = "";
    public string Search = "";
    string goback = "/";


    string api_uri = @"https://localhost:81";

    protected async override Task OnInitializedAsync()
    {
        var authenticationState = await AuthenticationStateTask;

        if (authenticationState?.User?.Identity is null || !authenticationState.User.Identity.IsAuthenticated)
        {
            NavigationManager.NavigateTo("/", true);
        }

        // Recupero la lista dei nomi in base al nome della foreign key (commesse) 
        FK_Father = Uri.EscapeDataString(FK_Father);
        TableModel = await httpClient.GetFromJsonAsync<List<GenericFF_Model>>(api_uri+@"/api/Views/client?father_name=Commesse");

    }

    // Controlla se la scritta ricercata appare in uno dei elementi che compongono il modulo
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



    private void clicked(string Father_Name, string Father_Key)
    {
        if (Father_Key != "Commesse")
        {
            NavigationManager.NavigateTo("view/suborder/" + CustomProtection.Decode(Father_Name));
        }
        else
        {
            NavigationManager.NavigateTo("view/orders/" + CustomProtection.Decode(Father_Name));
        }
    }



    private async Task Search_Main(string Search)
    {
        if (Search.Count() > 0)
        {
            TableModel = await httpClient.GetFromJsonAsync<List<GenericFF_Model>>(api_uri+@"/api/Views/ordersCheck/" + Search);
            StateHasChanged();//Refresh the component
        }
        else
        {
            NavigationManager.NavigateTo("/clients/", forceLoad: true);

        }
    }

    public async Task Enter(KeyboardEventArgs e)
    {
        if (e.Code == "Enter" || e.Code == "NumpadEnter")
        {
            await Search_Main(Search);
        }
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CustomIDataProtection CustomProtection { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient httpClient { get; set; }
    }
}
#pragma warning restore 1591
