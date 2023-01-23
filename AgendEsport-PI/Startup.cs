using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AgendEsport_PI.Startup))]
namespace AgendEsport_PI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
