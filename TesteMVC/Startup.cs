using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TesteMVC.Startup))]
namespace TesteMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
