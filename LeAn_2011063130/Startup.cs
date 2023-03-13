using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LeAn_2011063130.Startup))]
namespace LeAn_2011063130
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
