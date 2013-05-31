using System.Collections.Generic;
using StructureMap;
using StructureMap.Configuration.DSL;
using log4net;

namespace BuildHealth2013.WebUI.Infrastructure.StructureMap.Bootstrap
{
	public static class BootstrapperExpressions
	{
		public static Bootstrap WithContainer(this Bootstrap bootstrapper, IContainer container)
		{
			bootstrapper.Container = container;
			return bootstrapper;
		}

		public static Bootstrap WithRegistrar(this Bootstrap bootstrapper, IStructuremapRegistrar registrar)
		{
			bootstrapper.StructuremapRegistrar = registrar;
			return bootstrapper;
		}

        public static Bootstrap WithLogger(this Bootstrap bootstrapper, ILog logger)
		{
			bootstrapper.Logger = logger;
			return bootstrapper;
		}

		public static Bootstrap AdditionalRegristriesAre(this Bootstrap bootstrapper, IEnumerable<Registry> additionalRegistries)
		{
			bootstrapper.AdditionalRegistries = additionalRegistries;
			return bootstrapper;
		}
	}
}