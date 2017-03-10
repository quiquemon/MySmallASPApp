using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MySmallASPApp.Startup))]
namespace MySmallASPApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
