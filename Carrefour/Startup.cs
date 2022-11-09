using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Carrefour.Startup))]
namespace Carrefour
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
