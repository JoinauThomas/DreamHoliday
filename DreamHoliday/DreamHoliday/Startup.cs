using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DreamHoliday.Startup))]
namespace DreamHoliday
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
