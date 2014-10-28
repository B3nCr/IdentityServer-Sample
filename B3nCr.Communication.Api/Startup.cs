using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Thinktecture.IdentityModel.Owin.ScopeValidation;
using Thinktecture.IdentityServer.v3.AccessTokenValidation;

namespace B3nCr.Communication.Api
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseIdentityServerJwt(new JwtTokenValidationOptions
            {
                Authority = "https://b3ncr.auth:44340/identity"
            });

            app.RequireScopes(new ScopeValidationOptions() { Scopes = new[] { "sampleApi" }, AllowAnonymousAccess = true });

            // web api configuration
            var config = new HttpConfiguration();

            app.UseWebApi(config);
        }
    }
}