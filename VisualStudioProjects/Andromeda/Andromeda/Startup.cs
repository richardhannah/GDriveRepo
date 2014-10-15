using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Andromeda.Startup))]
namespace Andromeda
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
