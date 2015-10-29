using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Ninject.CoreContext;
using System.Web.Routing;

[assembly: OwinStartup(typeof(SignalrContext.Sample.Web.Startup))]

namespace SignalrContext.Sample.Web
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            NinjectContext.Get().AddModule<TestModule>().UseSignalR().WithAutoInjection().Initialize();
            app.MapSignalR();
        }
    }
}
