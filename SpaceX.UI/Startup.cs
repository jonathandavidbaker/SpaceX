using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SpaceX.UI.Startup))]
namespace SpaceX.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
