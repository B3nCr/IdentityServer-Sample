using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(B3nCr.Communication.Startup))]
namespace B3nCr.Communication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
