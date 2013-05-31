using AutoMapper;
using BuildHealth2013.WebUI.App_Start.BootStrap;
using BuildHealth2013.WebUI.Infrastructure.EntityFramework;
using StructureMap;
using StructureMap.Configuration.DSL;
using log4net;

namespace BuildHealth2013.WebUI.Infrastructure.StructureMap.Registries
{
    public class WebUIRegistry : Registry
    {
        public WebUIRegistry()
        {
            For<IDbContext>().HybridHttpOrThreadLocalScoped().Use<BuildHealthContext>();
            For<ILog>().Use(ctx => LogManager.GetLogger(ctx.Root.ConcreteType));
            For<IContainer>().Use(ObjectFactory.Container);

            Scan(scanner =>
            {
                scanner.AssemblyContainingType<WebUIRegistry>();
                scanner.WithDefaultConventions();
                scanner.AddAllTypesOf<Profile>();
                scanner.AddAllTypesOf<IBootstrapTask>();
            });
        }
    }
}