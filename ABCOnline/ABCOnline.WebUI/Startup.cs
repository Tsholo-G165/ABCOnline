using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ABCOnline.WebUI.Startup))]
namespace ABCOnline.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
