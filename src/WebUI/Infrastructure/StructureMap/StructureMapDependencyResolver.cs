using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http.Dependencies;
using Microsoft.Practices.ServiceLocation;
using StructureMap;

namespace BuildHealth2013.WebUI.Infrastructure.StructureMap
{
    public class StructureMapDependencyResolver : ServiceLocatorImplBase, IDependencyResolver
    {
        public StructureMapDependencyResolver(IContainer serviceLocator)
        {
            _serviceLocator = serviceLocator;
        }

        private readonly IContainer _serviceLocator;

        #region Implementation of IDisposable

        public void Dispose()
        {
            _serviceLocator.Dispose();
        }

        #endregion

        #region Implementation of IDependencyScope

        public override object GetService(Type serviceType)
        {
            if (serviceType == null)
            {
                return null;
            }

            return serviceType.IsAbstract || serviceType.IsInterface
                       ? _serviceLocator.TryGetInstance(serviceType)
                       : _serviceLocator.GetInstance(serviceType);
        }

        protected override object DoGetInstance(Type serviceType, string key)
        {
            if (string.IsNullOrEmpty(key))
            {
                return GetService(serviceType);
            }

            return _serviceLocator.GetInstance(serviceType, key);
        }

        protected override IEnumerable<object> DoGetAllInstances(Type serviceType)
        {
            return GetServices(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _serviceLocator.GetAllInstances(serviceType).Cast<object>();
        }

        public IDependencyScope BeginScope()
        {
            IContainer child = _serviceLocator.GetNestedContainer();
            return new StructureMapDependencyResolver(child);
        }

        #endregion
    }
}