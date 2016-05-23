using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KRAM1._0.Startup))]
namespace KRAM1._0
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
