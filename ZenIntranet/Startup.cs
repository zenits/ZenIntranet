using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ZenIntranet.Startup))]
namespace ZenIntranet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
