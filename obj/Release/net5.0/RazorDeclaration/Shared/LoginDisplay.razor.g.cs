// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace PDF_Portal_Azure_AD.Shared
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
#line 16 "Z:\PDF_WebSite\_Imports.razor"
using System.Net.Http.Json;

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
    public partial class LoginDisplay : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "Z:\PDF_WebSite\Shared\LoginDisplay.razor"
              
    // Aggioranmento Futuro 
    public string selected_update_Client { get; set; }
    //-------------------------------------------------
    #region "Admin Update Btn Staff"
    private bool _processing = false;
    List<string> InfoList = new();
    List<string> ClientsList = new List<string>();
    List<string> OrdersList;
    List<string> SuborderList;
    List<string> PDFList;
    List<string> PDF_files;
    string encodePath;
    string root_path = @"\\itcar1-ss1\Disegni\SPAC\Commesse";
    string api_url = "https://localhost:9100";
    string Log_String = " on " + DateTime.Now.ToString("g") + " Updated the DB";
    #endregion

    protected override async Task OnInitializedAsync()
    {
        encodePath = Uri.EscapeDataString(root_path);
        ClientsList = await httpClient.GetFromJsonAsync<List<string>>(api_url+@"/?F_path=" + encodePath);
    }
    

    // Questa functione scrive i logs ( messaggi ) su un file( crea se non esiste)
    public async Task Logging_Admin_Updates(string Admin , string strLog)
    {
        string file_Name = "Admin_Updates";
        string logFilePath = Path.Combine(Directory.GetCurrentDirectory(), @"Logs\" + file_Name + ".txt");
        FileInfo logFileInfo = new(logFilePath);
        DirectoryInfo logDirInfo = new(logFileInfo.DirectoryName);
        if (!logDirInfo.Exists) logDirInfo.Create();
        using (FileStream fileStream = new(logFilePath, FileMode.Append))
        {
            using StreamWriter log = new(fileStream);
            log.WriteLine(Admin + strLog);
        }

        await ProcessUpdate();
    }


    // Let me Explane this ProcessUpdate Function  >>>>>>
    //
    // 1) First of all, it takes the list of Folders o Files in the Path that I pass him (ex : S:\SPAC\Commesse )
    // 2) then it passes this list to an API , that will save each element of the list in the DB.
    // 3) Now the code iterate on the list and starts from point 1

    // Traduzione ( non letterale ) 

    // 1) E' una funzione a ciclo che prende dal API la lista dei percorsi (ex : S:\SPAC\Commesse )
    // 2) E per ogni percorso lo aggiorna sul DB e poi ricava la lista di elementi che contiene
    // 3) Si riparte del prima posto
    // Code Done >>>>>>
    public async Task ProcessUpdate()
    {
        _processing = true;
        string[] slash_path;
        string F_name = "";

        string json_User = JsonConvert.SerializeObject(ClientsList);


        // Preparing the httpRequestMessage to handle my request
        HttpRequestMessage httpRequestMessage = new();
        httpRequestMessage.Method = new HttpMethod("POST");
        httpRequestMessage.RequestUri = new Uri(api_url+@"/upDir?TableName=client&doUpdate=true");
        httpRequestMessage.Content = new StringContent(json_User);
        httpRequestMessage.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

        var response = await httpClient.SendAsync(httpRequestMessage);

        var responseStatusCode = response.StatusCode;

        if (responseStatusCode.ToString() == "OK")
        {
            response.Dispose();

            foreach (var client in ClientsList)
            {
                encodePath = Uri.EscapeDataString(client);
                OrdersList = await httpClient.GetFromJsonAsync<List<string>>(api_url+@"/?F_path=" + encodePath);
                json_User = JsonConvert.SerializeObject(OrdersList);
                Console.WriteLine(json_User);
                HttpRequestMessage httpRequestMessageOrder = new();
                httpRequestMessageOrder.Method = new HttpMethod("POST");
                httpRequestMessageOrder.RequestUri = new Uri(api_url+@"/upDir?TableName=orders&doUpdate=true");
                httpRequestMessageOrder.Content = new StringContent(json_User);
                httpRequestMessageOrder.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

                response = await httpClient.SendAsync(httpRequestMessageOrder);

                responseStatusCode = response.StatusCode;
                if (responseStatusCode.ToString() == "OK")
                {
                    response.Dispose();

                    foreach (var order in OrdersList)
                    {

                        encodePath = Uri.EscapeDataString(order);
                        SuborderList = await httpClient.GetFromJsonAsync<List<string>>(api_url+@"/?F_path=" + encodePath);
                        json_User = JsonConvert.SerializeObject(SuborderList);
                        HttpRequestMessage httpRequestMessageSub = new();
                        httpRequestMessageSub.Method = new HttpMethod("POST");
                        httpRequestMessageSub.RequestUri = new Uri(api_url+@"/upDir?TableName=suborder&doUpdate=true");
                        httpRequestMessageSub.Content = new StringContent(json_User);
                        httpRequestMessageSub.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

                        response = await httpClient.SendAsync(httpRequestMessageSub);

                        responseStatusCode = response.StatusCode;
                        if (responseStatusCode.ToString() == "OK")
                        {
                            response.Dispose();

                            foreach (var suborder in SuborderList)
                            {
                                encodePath = Uri.EscapeDataString(suborder);
                                PDFList = await httpClient.GetFromJsonAsync<List<string>>(api_url+@"/?F_path=" + encodePath);


                                json_User = JsonConvert.SerializeObject(PDFList);
                                HttpRequestMessage httpRequestMessagePDF = new();
                                httpRequestMessagePDF.Method = new HttpMethod("POST");
                                httpRequestMessagePDF.RequestUri = new Uri(api_url+@"/upDir?TableName=pdf&doUpdate=true");
                                httpRequestMessagePDF.Content = new StringContent(json_User);
                                httpRequestMessagePDF.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

                                response = await httpClient.SendAsync(httpRequestMessagePDF);

                                responseStatusCode = response.StatusCode;
                                if (responseStatusCode.ToString() == "OK")
                                {
                                    response.Dispose();

                                    foreach (var pdf in PDFList)
                                    {
                                        slash_path = pdf.Trim().Split(@"\");
                                        F_name = slash_path.Last();
                                        if (F_name.Contains("PDF") || F_name.Contains("pdf"))
                                        {
                                            encodePath = Uri.EscapeDataString(pdf);
                                            PDF_files = await httpClient.GetFromJsonAsync<List<string>>(api_url+@"/?F_path=" + encodePath);

                                            json_User = JsonConvert.SerializeObject(PDF_files);
                                            HttpRequestMessage httpRequestMessagePDF_File = new();
                                            httpRequestMessagePDF_File.Method = new HttpMethod("POST");
                                            httpRequestMessagePDF_File.RequestUri = new Uri(@"https://localhost:44315/upFile?doUpdate=true");
                                            httpRequestMessagePDF_File.Content = new StringContent(json_User);
                                            httpRequestMessagePDF_File.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

                                            response = await httpClient.SendAsync(httpRequestMessagePDF_File);

                                            responseStatusCode = response.StatusCode;
                                            if (responseStatusCode.ToString() == "OK")
                                            {
                                                continue;
                                            }
                                        }
                                        else
                                        {
                                            continue;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

        }
        _processing = false;
    }

    private async Task DeleteOldFiles()
    {

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient httpClient { get; set; }
    }
}
#pragma warning restore 1591
