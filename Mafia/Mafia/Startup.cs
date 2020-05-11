using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mafia.Startup))]
namespace Mafia
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
