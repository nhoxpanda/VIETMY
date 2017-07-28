using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VIETMY.Startup))]
namespace VIETMY
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}
