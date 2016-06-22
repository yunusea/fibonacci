using Contracts.FibonacciNumbers;
using Ninject;
using Ninject.Modules;
using Repository.FibonacciNumbers;
using System;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcApp.FibonacciNumbers
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private readonly IKernel kernel;

        public NinjectControllerFactory()
        {
            kernel = new StandardKernel(new NinjectBindingModule());
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)kernel.Get(controllerType);
        }
    }

    public class NinjectBindingModule : NinjectModule
    {
        public override void Load()
        {
            Kernel.Bind<IFibonacciNumber>().To<FibonacciNumber>();
        }
    }
}