using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebFormsApp_net452_cs_IndAuthwithAI_1.Startup))]
namespace WebFormsApp_net452_cs_IndAuthwithAI_1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
