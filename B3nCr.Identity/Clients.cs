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
            return new[]
        {
            new Client 
            {
                Enabled = true,
                ClientName = "GrpTxt",
                ClientId = "grptxt",
                Flow = Flows.Hybrid,

                RedirectUris = new List<Uri>
                {
                    new Uri("https://b3ncr.comms:44341/")
                }
            }
        };
        }
    }
}