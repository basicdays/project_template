using System.Collections.Generic;
using BuildHealth2013.WebUI.Infrastructure.StructureMap.Registries;
using StructureMap;
using StructureMap.Configuration.DSL;

namespace BuildHealth2013.WebUI.Infrastructure.StructureMap
{
    public class StructuremapRegistrar : IStructuremapRegistrar
    {
        public void ConfigureDependencies(IContainer container)
        {
            ConfigureDependencies(container, new List<Registry>());
        }

        public void ConfigureDependencies(IContainer container, IEnumerable<Registry> registries)
        {
            container.Configure(config =>
            {
                config.AddRegistry<WebUIRegistry>();

                foreach (var registry in registries)
                {
                    config.AddRegistry(registry);
                }
            });
        }
    }
}