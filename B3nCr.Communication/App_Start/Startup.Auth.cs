using System;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.Google;
using Owin;
using B3nCr.Communication.Models;
using System.Configuration;
using Microsoft.Owin.Security.OpenIdConnect;
using Thinktecture.IdentityServer.v3.AccessTokenValidation;

namespace B3nCr.Communication
{
    public partial class Startup
    {
        // For more information on configuring authentication, please visit http://go.microsoft.com/fwlink/?LinkId=301864
        public void ConfigureAuth(IAppBuilder app)
        {
            const string IdentityServerUrlKey = "IdentityServerUrl";
            const string RedirectUriKey = "IdentityRedirectUrl";
            const string ClientId = "grptxt";

            app.UseIdentityServerJwt(new JwtTokenValidationOptions
            {
                Authority = "https://b3ncr.auth:44340/identity"
            }); 

            var identityServerUri = ConfigurationManager.AppSettings[IdentityServerUrlKey];
            var redirectUri = ConfigurationManager.AppSettings[RedirectUriKey];

            app.UseOpenIdConnectAuthentication(new OpenIdConnectAuthenticationOptions
            {
                Authority = identityServerUri,
                ClientId = ClientId,
                RedirectUri = redirectUri,

                SignInAsAuthenticationType = "Cookies"
            });
        }
    }
}