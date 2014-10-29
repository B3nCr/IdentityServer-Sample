using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Thinktecture.IdentityServer.Core.Models;

namespace B3nCr.Identity
{
    public static class Clients
    {
        public static IEnumerable<Client> Get()
        {
            var mvcClient = new Client
            {
                Enabled = true,
                ClientName = "GrpTxt",
                ClientId = "grptxt",
                Flow = Flows.Hybrid,
                RedirectUris = new List<Uri>
                {
                    new Uri("https://b3ncr.comms:44341/"),
                    new Uri("https://b3ncr.comms:44341/#/loggedin?")
                }
            };
            var apiClient = new Client
            {
                Enabled = true,
                ClientName = "API Client",
                ClientId = "mvc_service",
                ClientSecret = "secret",
                Flow = Flows.ClientCredentials
            };
            var angularClient = new Client
            {
                Enabled = true,
                ClientName = "txtm8",
                ClientId = "txtm8",
                Flow = Flows.Hybrid,
                RedirectUris = new List<Uri> { new Uri("https://b3ncr.comms:44341/#/loggedin?") }
            };
            var implicitClient = new Client
            {
                Enabled = true,
                ClientName = "Implicit Client",
                ClientId = "Implicit",
                ClientSecret = "ABC123",
                Flow = Flows.Implicit,
                RedirectUris = new List<Uri> 
                {
                    new Uri("https://b3ncr.comms:44341/#/loggedin?") 
                },
                RequireConsent = true
            };
            return new List<Client> { mvcClient, implicitClient, apiClient };
        }
    }
}