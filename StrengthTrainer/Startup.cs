using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StrengthTrainer.Startup))]
namespace StrengthTrainer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
