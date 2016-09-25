using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(desafioMusical2.Startup))]
namespace desafioMusical2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
