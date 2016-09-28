using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(anew.no.Startup))]
namespace anew.no
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
