using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WADLAB4.Startup))]
namespace WADLAB4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
