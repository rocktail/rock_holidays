using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RockHolidays.Startup))]
namespace RockHolidays
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
