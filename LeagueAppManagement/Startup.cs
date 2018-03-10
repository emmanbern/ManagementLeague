using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LeagueAppManagement.Startup))]
namespace LeagueAppManagement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
