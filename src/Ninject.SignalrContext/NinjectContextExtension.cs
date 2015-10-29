using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using Ninject.CoreContext;
using Ninject.SignalrContext;

namespace Ninject.CoreContext
{
    /// <summary>
    /// Ninject Context extension
    /// </summary>
    public static class NinjectContextExtension
    {
        /// <summary>
        /// True if WebApi is initialized, otherwise false.
        /// </summary>
        static bool _signalrInitialized;

        /// <summary>
        /// Use WCF
        /// </summary>
        public static NinjectContext UseSignalR(this NinjectContext context)
        {
            if (!_signalrInitialized)
            {
                context.Use(kernel =>
                {
                    GlobalHost.DependencyResolver.Register(typeof (IHubActivator), () => new NinjectHubActivator(kernel));
                });
                _signalrInitialized = true;
            }
            return context;
        }
    }
}
