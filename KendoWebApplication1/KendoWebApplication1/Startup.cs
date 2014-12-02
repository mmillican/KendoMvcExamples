using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KendoWebApplication1.Startup))]
namespace KendoWebApplication1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
