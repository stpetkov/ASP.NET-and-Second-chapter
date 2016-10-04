using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(try1.Startup))]
namespace try1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
