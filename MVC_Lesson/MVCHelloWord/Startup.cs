using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCHelloWord.Startup))]
namespace MVCHelloWord
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
