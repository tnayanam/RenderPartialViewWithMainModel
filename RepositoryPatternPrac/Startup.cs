using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RepositoryPatternPrac.Startup))]
namespace RepositoryPatternPrac
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
