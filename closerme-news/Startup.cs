using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(closerme_news.Startup))]
namespace closerme_news
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
