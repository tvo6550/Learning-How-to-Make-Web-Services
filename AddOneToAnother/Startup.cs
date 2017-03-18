using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AddOneToAnother.Startup))]
namespace AddOneToAnother
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
