using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

using Microsoft.Owin.Security.OAuth;

namespace B3nCr.Communication
{
    public static class WebApiConfig
    {
        public static HttpConfiguration Register()
        {
            // Web API configuration and services
            var config = new HttpConfiguration();

            config.SuppressDefaultHostAuthentication();

            // Web API routes
            //config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            return config;
        }
    }
}
