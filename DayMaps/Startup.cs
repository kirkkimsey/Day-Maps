using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DayMaps.Startup))]
namespace DayMaps
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
