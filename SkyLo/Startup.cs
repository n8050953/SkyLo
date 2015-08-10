using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SkyLo.Startup))]
namespace SkyLo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
