using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OAuth;
using Microsoft.Owin.Security.OpenIdConnect;
using Owin;
using System;
using System.Configuration;
using System.Web.Http;
using Thinktecture.IdentityModel.Owin.ScopeValidation;
using Thinktecture.IdentityServer.v3.AccessTokenValidation;

[assembly: OwinStartupAttribute(typeof(B3nCr.Communication.Startup))]
namespace B3nCr.Communication
{
    public partial class Startup
    {
        const string IdentityServerUrlKey = "IdentityServerUrl";
        const string RedirectUriKey = "IdentityRedirectUrl";
        const string ClientId = "grptxt";

        public void Configuration(IAppBuilder app)
        {
            var identityServerUri = ConfigurationManager.AppSettings[IdentityServerUrlKey];
            var redirectUri = ConfigurationManager.AppSettings[RedirectUriKey];

            identityServerUri = "https://b3ncr.auth:44340/identity";
            redirectUri = "https://b3ncr.comms:44341/";

            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = "Cookies"
            });
            // Enable the application to use a cookie to store information for the signed in user
            app.UseOpenIdConnectAuthentication(new OpenIdConnectAuthenticationOptions
            {
                Authority = identityServerUri,
                ClientId = ClientId,
                RedirectUri = redirectUri,
                Scope = "openid profile sampleApi",
                SignInAsAuthenticationType = "Cookies"
            });

            app.Map("/api", inner =>
            {
                // Web API configuration and services
                var config = new HttpConfiguration();

                //config.SuppressDefaultHostAuthentication();

                //config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));

                inner.UseIdentityServerJwt(new JwtTokenValidationOptions
                {
                    Authority = "https://b3ncr.auth:44340/identity"

                });
                inner.RequireScopes(new ScopeValidationOptions() { Scopes = new[] { "sampleApi" } });

                // Web API routes
                //config.MapHttpAttributeRoutes();

                config.Routes.MapHttpRoute(
                    name: "DefaultApi",
                    routeTemplate: "{controller}/{id}",
                    defaults: new { id = RouteParameter.Optional }
                );

                inner.UseWebApi(config);
            });
        }
    }
}
