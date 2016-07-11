using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LanguageTranslation.Startup))]
namespace LanguageTranslation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
