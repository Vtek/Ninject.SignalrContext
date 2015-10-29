using Ninject.CoreContext;
using SignalrContext.Sample.Web.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalrContext.Sample.Web
{
    public class TestModule : AutoInjectionModule
    {
        public override void Load()
        {
            Bind<ITestService>().To<TestService>().InHttpScope();
        }
    }
}