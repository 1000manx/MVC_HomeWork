using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Money02.Startup))]
namespace Money02
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
