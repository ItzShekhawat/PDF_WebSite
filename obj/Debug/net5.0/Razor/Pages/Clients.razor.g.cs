#pragma checksum "Z:\PDF_WebSite\Pages\Clients.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "628ed3a3f9a9309ae9596464d5f1e71c792a0ca5"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Roles", "User, Admin");
            __builder.AddAttribute(2, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((user_context) => (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudItem>(3);
                __builder2.AddAttribute(4, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 10 "Z:\PDF_WebSite\Pages\Clients.razor"
                     12

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(5, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 10 "Z:\PDF_WebSite\Pages\Clients.razor"
                             12

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 10 "Z:\PDF_WebSite\Pages\Clients.razor"
                                     12

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(7, "Style", "padding:10px");
                __builder2.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudTextField<string>>(9);
                    __builder3.AddAttribute(10, "Immediate", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 11 "Z:\PDF_WebSite\Pages\Clients.razor"
                                                                     true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(11, "onkeypress", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 11 "Z:\PDF_WebSite\Pages\Clients.razor"
                                                                                        Enter

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(12, "Label", "Ricerca per commessa o descrizione");
                    __builder3.AddAttribute(13, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 11 "Z:\PDF_WebSite\Pages\Clients.razor"
                                                                                                                                                   Variant.Outlined

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(14, "minlength", "3");
                    __builder3.AddAttribute(15, "Adornment", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Adornment>(
#nullable restore
#line 11 "Z:\PDF_WebSite\Pages\Clients.razor"
                                                                                                                                                                                              Adornment.Start

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(16, "AdornmentIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "Z:\PDF_WebSite\Pages\Clients.razor"
                                                                                                                                                                                                                               Icons.Filled.Search

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(17, "AdornmentColor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 11 "Z:\PDF_WebSite\Pages\Clients.razor"
                                                                                                                                                                                                                                                                    Color.Dark

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(18, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 11 "Z:\PDF_WebSite\Pages\Clients.razor"
                                                  Search

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(19, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Search = __value, Search))));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\r\n\r\n        <br>\r\n        <br>\r\n\r\n        ");
                __Blazor.PDF_Portal_Azure_AD.Pages.Clients.TypeInference.CreateMudTable_0(__builder2, 21, 22, 
#nullable restore
#line 17 "Z:\PDF_WebSite\Pages\Clients.razor"
                         TableModel

#line default
#line hidden
#nullable disable
                , 23, 
#nullable restore
#line 17 "Z:\PDF_WebSite\Pages\Clients.razor"
                                            true

#line default
#line hidden
#nullable disable
                , 24, 
#nullable restore
#line 17 "Z:\PDF_WebSite\Pages\Clients.razor"
                                                            true

#line default
#line hidden
#nullable disable
                , 25, 
#nullable restore
#line 17 "Z:\PDF_WebSite\Pages\Clients.razor"
                                                                          new Func<GenericFF_Model, bool>(FilterFunc)

#line default
#line hidden
#nullable disable
                , 26, (__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudText>(27);
                    __builder3.AddAttribute(28, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 19 "Z:\PDF_WebSite\Pages\Clients.razor"
                               Typo.h6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(30, "Tabella Clients");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(31, "\r\n                ");
                    __builder3.OpenComponent<MudBlazor.MudSpacer>(32);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(33, "\r\n                ");
                    __builder3.OpenComponent<MudBlazor.MudTextField<string>>(34);
                    __builder3.AddAttribute(35, "Placeholder", "Search");
                    __builder3.AddAttribute(36, "Adornment", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Adornment>(
#nullable restore
#line 21 "Z:\PDF_WebSite\Pages\Clients.razor"
                                                                                                    Adornment.Start

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(37, "AdornmentIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "Z:\PDF_WebSite\Pages\Clients.razor"
                                              Icons.Material.Filled.Search

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(38, "IconSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 22 "Z:\PDF_WebSite\Pages\Clients.razor"
                                                                                      Size.Medium

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(39, "Class", "mt-0");
                    __builder3.AddAttribute(40, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 21 "Z:\PDF_WebSite\Pages\Clients.razor"
                                                      searchString

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(41, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => searchString = __value, searchString))));
                    __builder3.CloseComponent();
                }
                , 42, (__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudTh>(43);
                    __builder3.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudIcon>(45);
                        __builder4.AddAttribute(46, "Style", "font-size: 20px");
                        __builder4.AddAttribute(47, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "Z:\PDF_WebSite\Pages\Clients.razor"
                                                                Icons.Rounded.FolderOpen

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddContent(48, " Folder");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                , 49, (context) => (__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudTd>(50);
                    __builder3.AddAttribute(51, "DataLabel", "Folder_name");
                    __builder3.AddAttribute(52, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "Z:\PDF_WebSite\Pages\Clients.razor"
                                                         () => clicked(context.FF_Name, context.FK_Father)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(53, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(54, 
#nullable restore
#line 28 "Z:\PDF_WebSite\Pages\Clients.razor"
                                                                                                             context.FF_Name

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                }
                , 55, (__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudText>(56);
                    __builder3.AddAttribute(57, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(58, "No matching records found");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                , 59, (__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudText>(60);
                    __builder3.AddAttribute(61, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(62, "Loading...");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                );
            }
            ));
            __builder.AddAttribute(63, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudAlert>(64);
                __builder2.AddAttribute(65, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(66, " Please Login");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(67, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudButton>(68);
                __builder2.AddAttribute(69, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "Z:\PDF_WebSite\Pages\Clients.razor"
                            ()=>NavigationManager.NavigateTo(goback)

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(70, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(71, "Back to Login ");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
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

    // Variabile globale che fornisce la parte fissa del url per collegarsi al API
    string api_uri = GlobalStorage.APIurl;

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


    // si avvia per passare alla prossima pagina, passando nel url il nome del cliente scelta e cos' filtrando la risposta per la prossima tabella
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


    // Permette di cercare direttamente nella tabella orders, filtrando per parola cercata e non per cliente
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

    // Ascolta il tasto Invio per avviare la ricerca
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
namespace __Blazor.PDF_Portal_Azure_AD.Pages.Clients
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTable_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<T> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::System.Func<T, global::System.Boolean> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5, int __seq6, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg6, int __seq7, global::Microsoft.AspNetCore.Components.RenderFragment __arg7, int __seq8, global::Microsoft.AspNetCore.Components.RenderFragment __arg8)
        {
        __builder.OpenComponent<global::MudBlazor.MudTable<T>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "Hover", __arg1);
        __builder.AddAttribute(__seq2, "Bordered", __arg2);
        __builder.AddAttribute(__seq3, "Filter", __arg3);
        __builder.AddAttribute(__seq4, "ToolBarContent", __arg4);
        __builder.AddAttribute(__seq5, "HeaderContent", __arg5);
        __builder.AddAttribute(__seq6, "RowTemplate", __arg6);
        __builder.AddAttribute(__seq7, "NoRecordsContent", __arg7);
        __builder.AddAttribute(__seq8, "LoadingContent", __arg8);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
