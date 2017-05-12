using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BCGFormGenerator.Startup))]
namespace BCGFormGenerator
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
