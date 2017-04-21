using System;
using System.Collections.Generic;
using Ninject;
using System.Web.Mvc;
using TrainFinder.Domain.Entities;
using TrainFinder.Domain.Abstract;
using TrainFinder.Domain.Concrete;

namespace TrainFinder.WebUI.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }
        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            kernel.Bind<ITrainRepository>().To<EfTrainRepository>();
        }
    }
}