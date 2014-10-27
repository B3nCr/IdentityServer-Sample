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
                    new Uri("https://b3ncr.comms:44341/")
                }
            };
            var angularClient = new Client
            {
                Enabled = true,
                ClientName = "txtm8",
                ClientId = "txtm8",
                Flow = Flows.Hybrid,
                RedirectUris = new List<Uri> {  new Uri("https://b3ncr.comms:44341/#/loggedin?")}
            };
            return new List<Client> { mvcClient, angularClient };
        }
    }
}