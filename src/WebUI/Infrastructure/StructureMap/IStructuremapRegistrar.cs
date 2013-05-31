using System.Collections.Generic;
using StructureMap;
using StructureMap.Configuration.DSL;

namespace BuildHealth2013.WebUI.Infrastructure.StructureMap
{
	public interface IStructuremapRegistrar
	{
		void ConfigureDependencies(IContainer container);

		void ConfigureDependencies(IContainer container, IEnumerable<Registry> registries);
	}
}
