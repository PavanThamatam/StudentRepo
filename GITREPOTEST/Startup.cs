using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GITREPOTEST.Startup))]
namespace GITREPOTEST
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
