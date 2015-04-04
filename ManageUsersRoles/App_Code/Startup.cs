using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimpleAuthSite.Startup))]
namespace SimpleAuthSite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
