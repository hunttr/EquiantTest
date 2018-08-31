using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tester.Startup))]
namespace Tester
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            
        }
    }
}
