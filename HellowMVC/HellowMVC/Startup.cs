using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HellowMVC.Startup))]
namespace HellowMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
