using Microsoft.AspNet.SignalR;
using SignalrContext.Sample.Web.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalrContext.Sample.Web
{
    public class PropertyInjectionHub : Hub
    {
        public ITestService TestService { get; set; }

        public void Send(string name, string message)
        {
            // Call the broadcastMessage method to update clients.
            Clients.All.broadcastMessage(name, TestService.HelloWorld());
        }
    }
}