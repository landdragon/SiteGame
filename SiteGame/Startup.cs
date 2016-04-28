using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SiteGame.Startup))]
namespace SiteGame
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
