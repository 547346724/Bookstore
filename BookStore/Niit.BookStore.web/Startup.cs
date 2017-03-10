using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Niit.BookStore.web.Startup))]
namespace Niit.BookStore.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
