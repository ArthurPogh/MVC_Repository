using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcAutent.Startup))]
namespace MvcAutent
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
