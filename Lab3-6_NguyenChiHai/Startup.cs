using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab3_6_NguyenChiHai.Startup))]
namespace Lab3_6_NguyenChiHai
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
