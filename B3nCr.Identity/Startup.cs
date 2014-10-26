using B3nCr.Identity;
using Owin;
using System;
using System.Security.Cryptography.X509Certificates;
using Thinktecture.IdentityServer.Core.Configuration;
using Thinktecture.IdentityServer.Core.Models;

namespace B3nCr.Identity
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.Map("/identity", idsrvApp =>
            {
                idsrvApp.UseIdentityServer(new IdentityServerOptions
                {
                    SiteName = "B3nCr Identity Server",
                    IssuerUri = "https://b3ncr.auth/embedded",
                    SigningCertificate = LoadCertificate(),

                    Factory = InMemoryFactory.Create(
                        users: Users.Get(),
                        clients: Clients.Get(),
                        scopes: Scope.StandardScopes)
                });
            });
        }

        X509Certificate2 LoadCertificate()
        {
            var store = new X509Store(StoreName.My, StoreLocation.LocalMachine);
            
            store.Open(OpenFlags.ReadOnly);

            var certCollection = store.Certificates.Find(X509FindType.FindByThumbprint, "D0AFE6C9CF53CFFA5EEDE83A310EA06B31954015", false);

            return new X509Certificate2(certCollection[0]);
        }
    }
}