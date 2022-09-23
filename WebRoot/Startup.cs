using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebRoot.Startup))]
namespace WebRoot
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
