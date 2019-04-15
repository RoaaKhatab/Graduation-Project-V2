using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SchoolGuide4.Startup))]
namespace SchoolGuide4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
