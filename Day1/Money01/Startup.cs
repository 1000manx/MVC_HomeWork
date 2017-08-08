using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Money01.Startup))]
namespace Money01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
