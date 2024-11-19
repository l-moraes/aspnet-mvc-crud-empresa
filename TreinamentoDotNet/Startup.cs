using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(TreinamentoDotNet.StartupOwin))]

namespace TreinamentoDotNet
{
    public partial class StartupOwin
    {
        public void Configuration(IAppBuilder app)
        {
            //AuthStartup.ConfigureAuth(app);
        }
    }
}
