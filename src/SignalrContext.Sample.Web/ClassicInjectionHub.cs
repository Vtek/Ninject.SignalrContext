using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using SignalrContext.Sample.Web.Services;

namespace SignalrContext.Sample.Web
{
    public class ClassicInjectionHub : Hub
    {
        ITestService _testService;

        public ClassicInjectionHub(ITestService testService)
        {
            _testService = testService;
        }

        public void Send(string name, string message)
        {
            // Call the broadcastMessage method to update clients.
            Clients.All.broadcastMessage(name, _testService.HelloWorld());
        }
    }
}