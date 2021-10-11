using Blazored.SessionStorage;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Identity.Web;
using Microsoft.Identity.Web.UI;
using MudBlazor.Services;
using PDF_Portal_Azure_AD.Data;
using System.IdentityModel.Tokens.Jwt;

namespace PDF_Portal_Azure_AD
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            #region "Adding the old code" 
            // Css Framework
            services.AddMudServices();

            // Session Storage Service Setup 
            services.AddBlazoredSessionStorage();
            // Caching
            services.AddMemoryCache();
            // Data Protection
            services.AddSingleton<UniqueCode>();
            services.AddSingleton<CustomIDataProtection>();

            // Just saying that the token contains custom claims too
            JwtSecurityTokenHandler.DefaultMapInboundClaims = false;
            #endregion

            // The Configuration that handles the OIDC Authentication 
            services.AddAuthentication(OpenIdConnectDefaults.AuthenticationScheme)
                .AddMicrosoftIdentityWebApp(Configuration.GetSection("AzureAd"))
                .EnableTokenAcquisitionToCallDownstreamApi(new string[] { "User.Read" })
                .AddInMemoryTokenCaches();

            // This will block the whole site, and it will require an authorized user to access any page of the site
            services.AddControllersWithViews(options =>
            {
                var policy = new AuthorizationPolicyBuilder()
                    .RequireAuthenticatedUser()
                    .Build();
                options.Filters.Add(new AuthorizeFilter(policy));
            });

            services.AddRazorPages()
                 .AddMicrosoftIdentityUI();

            services.AddServerSideBlazor()
                .AddMicrosoftIdentityConsentHandler();

            // Just configure the claims I need from the access token 
            services.Configure<OpenIdConnectOptions>(OpenIdConnectDefaults.AuthenticationScheme, options =>
            {
                // The claim in the Jwt token where App roles are available.
                options.TokenValidationParameters.RoleClaimType = "roles";
                options.TokenValidationParameters.NameClaimType = "name";
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            // This configuartion gets active when the user is logf-out form the site and the OIDC leaves the user on a blank page( after cleaning the cookie)
            app.Use(async (context, next) => {
                if (context.Request.Path
                        .Equals("/signout-oidc", System.StringComparison.OrdinalIgnoreCase))
                {
                    context.Response.Redirect("/");

                }else if (context.Request.Path
                        .Equals("/signin-oidc", System.StringComparison.OrdinalIgnoreCase))
                {
                    context.Response.Redirect("/clients/");
                }
                await next.Invoke();
            });

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });

        }
    }
}
