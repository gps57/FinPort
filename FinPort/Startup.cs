using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FinPort.Startup))]
namespace FinPort
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
