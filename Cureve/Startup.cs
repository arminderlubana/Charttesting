using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cureve.Startup))]
namespace Cureve
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
