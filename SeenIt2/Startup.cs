using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SeenIt2.Startup))]
namespace SeenIt2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
