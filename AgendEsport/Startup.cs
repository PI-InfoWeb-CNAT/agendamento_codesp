using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AgendEsport.Startup))]
namespace AgendEsport
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
