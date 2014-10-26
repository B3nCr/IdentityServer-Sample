using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Thinktecture.IdentityServer.v3.AccessTokenValidation;

namespace B3nCr.Communication.Api
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseIdentityServerJwt(new JwtTokenValidationOptions
            {
                Authority = "https://b3ncr.auth:44343identity"
            });

            app.RequireScopes("sampleApi");

            // web api configuration
            var config = new HttpConfiguration();
            config.MapHttpAttributeRoutes();

            app.UseWebApi(config);
        }
    }
}