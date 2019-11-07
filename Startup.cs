using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestAppOverDevOpsServer.Startup))]
namespace TestAppOverDevOpsServer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
