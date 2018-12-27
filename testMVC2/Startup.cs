using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(testMVC2.Startup))]
namespace testMVC2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
