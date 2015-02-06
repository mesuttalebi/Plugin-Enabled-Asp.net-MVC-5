using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PluggableWebApplication.Startup))]
namespace PluggableWebApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
