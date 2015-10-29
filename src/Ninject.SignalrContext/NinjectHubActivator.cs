using Microsoft.AspNet.SignalR.Hubs;

namespace Ninject.SignalrContext
{
    public class NinjectHubActivator : IHubActivator
    {
        private IKernel _kernel;

        public NinjectHubActivator(IKernel kernel)
        {
            _kernel = kernel;
        }

        public IHub Create(HubDescriptor descriptor)
        {
            return _kernel.GetService(descriptor.HubType) as IHub;
        }
    }
}
