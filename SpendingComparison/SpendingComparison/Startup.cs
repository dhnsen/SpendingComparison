using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SpendingComparison.Startup))]
namespace SpendingComparison
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
