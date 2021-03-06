﻿using System;
using System.Collections.Generic;
using BuildHealth2013.WebUI.App_Start.BootStrap;
using StructureMap;
using StructureMap.Configuration.DSL;
using log4net;

namespace BuildHealth2013.WebUI.Infrastructure.StructureMap.Bootstrap
{
	public class Bootstrap : IDisposable
	{
		public IContainer Container { get; set; }
        public ILog Logger { get; set; }
		public IStructuremapRegistrar StructuremapRegistrar { get; set; }
		public IEnumerable<Registry> AdditionalRegistries { get; set; }

		private Bootstrapper _bootstraper;

		public Bootstrap Start()
		{
			if(Container == null) {
				throw new BootstrapException("A container is required!");
			}
			if (StructuremapRegistrar == null){
				throw new BootstrapException("the structure map configuration registrar is required!");
			}
			if (Logger == null) {
				throw new BootstrapException("Some kind of logger is required!");
			}

			var dependencyRegistrar = new DependencyRegistrar(Container, StructuremapRegistrar, AdditionalRegistries);
			_bootstraper = new Bootstrapper(dependencyRegistrar, Logger);

			_bootstraper.Bootstrap();
			return this;
		}

		public void Dispose()
		{
			_bootstraper.Dispose();
		}
	}
}
