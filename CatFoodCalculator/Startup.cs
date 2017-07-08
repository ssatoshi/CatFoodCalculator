using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CatFoodCalculator.Startup))]
namespace CatFoodCalculator
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
