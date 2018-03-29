using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SecureWebApi.Startup))]
namespace SecureWebApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
