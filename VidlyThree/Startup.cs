using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VidlyThree.Startup))]
namespace VidlyThree
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
