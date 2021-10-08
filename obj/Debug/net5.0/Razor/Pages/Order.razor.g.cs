#pragma checksum "Z:\PDF_WebSite\Pages\Order.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7b24da3eae85712d117e598b076dafc54a60c7f"
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
using PortalModels;

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
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(0);
            __builder.AddAttribute(1, "Roles", "Admin, User");
            __builder.AddAttribute(2, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((user_context) => (__builder2) => {
                __Blazor.PDF_Portal_Azure_AD.Pages.Order.TypeInference.CreateMudTable_0(__builder2, 3, 4, 
#nullable restore
#line 12 "Z:\PDF_WebSite\Pages\Order.razor"
                         orders

#line default
#line hidden
#nullable disable
                , 5, 
#nullable restore
#line 12 "Z:\PDF_WebSite\Pages\Order.razor"
                                        true

#line default
#line hidden
#nullable disable
                , 6, 
#nullable restore
#line 12 "Z:\PDF_WebSite\Pages\Order.razor"
                                                        true

#line default
#line hidden
#nullable disable
                , 7, 
#nullable restore
#line 12 "Z:\PDF_WebSite\Pages\Order.razor"
                                                                      new Func<GenericFF_Model, bool>(FilterFunc)

#line default
#line hidden
#nullable disable
                , 8, (__builder3) => {
                    __builder3.AddMarkupContent(9, "<col style=\"width: 90%;\">\r\n                <col>");
                }
                , 10, (__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudText>(11);
                    __builder3.AddAttribute(12, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 18 "Z:\PDF_WebSite\Pages\Order.razor"
                               Typo.h6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(14, "Table Orders");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(15, "\r\n                ");
                    __builder3.OpenComponent<MudBlazor.MudSpacer>(16);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(17, "\r\n                ");
                    __builder3.OpenComponent<MudBlazor.MudTextField<string>>(18);
                    __builder3.AddAttribute(19, "Placeholder", "Search");
                    __builder3.AddAttribute(20, "Adornment", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Adornment>(
#nullable restore
#line 20 "Z:\PDF_WebSite\Pages\Order.razor"
                                                                                                    Adornment.Start

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(21, "AdornmentIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "Z:\PDF_WebSite\Pages\Order.razor"
                                              Icons.Material.Filled.Search

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(22, "IconSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 21 "Z:\PDF_WebSite\Pages\Order.razor"
                                                                                      Size.Medium

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(23, "Class", "mt-0");
                    __builder3.AddAttribute(24, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 20 "Z:\PDF_WebSite\Pages\Order.razor"
                                                      searchString

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(25, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => searchString = __value, searchString))));
                    __builder3.CloseComponent();
                }
                , 26, (__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudTh>(27);
                    __builder3.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudIcon>(29);
                        __builder4.AddAttribute(30, "Style", "font-size: 30px");
                        __builder4.AddAttribute(31, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "Z:\PDF_WebSite\Pages\Order.razor"
                                                                Icons.Filled.Folder

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddContent(32, " Folder");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(33, "\r\n                ");
                    __builder3.OpenComponent<MudBlazor.MudTh>(34);
                    __builder3.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudIcon>(36);
                        __builder4.AddAttribute(37, "Style", "font-size: 30px");
                        __builder4.AddAttribute(38, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "Z:\PDF_WebSite\Pages\Order.razor"
                                                                Icons.Filled.Folder

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddContent(39, " Origin");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                , 40, (context) => (__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudTd>(41);
                    __builder3.AddAttribute(42, "DataLabel", "Folder_name");
                    __builder3.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "Z:\PDF_WebSite\Pages\Order.razor"
                                                         ()=>clicked(context.FF_Name)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(45, 
#nullable restore
#line 28 "Z:\PDF_WebSite\Pages\Order.razor"
                                                                                        context.FF_Name

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(46, "\r\n                ");
                    __builder3.OpenComponent<MudBlazor.MudTd>(47);
                    __builder3.AddAttribute(48, "DataLabel", "Father_Name");
                    __builder3.AddAttribute(49, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "Z:\PDF_WebSite\Pages\Order.razor"
                                                         ()=>clicked(context.FF_Name)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(50, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(51, 
#nullable restore
#line 29 "Z:\PDF_WebSite\Pages\Order.razor"
                                                                                        context.FK_Father

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                }
                , 52, (__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudText>(53);
                    __builder3.AddAttribute(54, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(55, "No matching records found");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                , 56, (__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudText>(57);
                    __builder3.AddAttribute(58, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(59, "Loading...");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                );
            }
            ));
            __builder.AddAttribute(60, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudAlert>(61);
                __builder2.AddAttribute(62, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(63, " Please Login");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(64, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudButton>(65);
                __builder2.AddAttribute(66, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "Z:\PDF_WebSite\Pages\Order.razor"
                            ()=>NavigationManager.NavigateTo(goback)

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(67, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(68, "Back to Login ");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
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
namespace __Blazor.PDF_Portal_Azure_AD.Pages.Order
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTable_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<T> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::System.Func<T, global::System.Boolean> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5, int __seq6, global::Microsoft.AspNetCore.Components.RenderFragment __arg6, int __seq7, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg7, int __seq8, global::Microsoft.AspNetCore.Components.RenderFragment __arg8, int __seq9, global::Microsoft.AspNetCore.Components.RenderFragment __arg9)
        {
        __builder.OpenComponent<global::MudBlazor.MudTable<T>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "Hover", __arg1);
        __builder.AddAttribute(__seq2, "Bordered", __arg2);
        __builder.AddAttribute(__seq3, "Filter", __arg3);
        __builder.AddAttribute(__seq4, "ColGroup", __arg4);
        __builder.AddAttribute(__seq5, "ToolBarContent", __arg5);
        __builder.AddAttribute(__seq6, "HeaderContent", __arg6);
        __builder.AddAttribute(__seq7, "RowTemplate", __arg7);
        __builder.AddAttribute(__seq8, "NoRecordsContent", __arg8);
        __builder.AddAttribute(__seq9, "LoadingContent", __arg9);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
