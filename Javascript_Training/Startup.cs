using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Javascript_Training.Startup))]
namespace Javascript_Training
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
