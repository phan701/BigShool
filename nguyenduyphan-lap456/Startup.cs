using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(nguyenduyphan_lap456.Startup))]
namespace nguyenduyphan_lap456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
