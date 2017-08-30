using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebForm_WebApplication.Startup))]
namespace WebForm_WebApplication
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
