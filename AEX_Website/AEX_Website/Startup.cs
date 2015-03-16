using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AEXApplication.Startup))]
namespace AEXApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
