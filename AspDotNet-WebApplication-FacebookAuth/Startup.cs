using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspDotNet_WebApplication_FacebookAuth.Startup))]
namespace AspDotNet_WebApplication_FacebookAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
