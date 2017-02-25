using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MarkIt.Startup))]
namespace MarkIt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
