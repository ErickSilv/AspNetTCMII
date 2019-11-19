using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TCM_II.Startup))]
namespace TCM_II
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
