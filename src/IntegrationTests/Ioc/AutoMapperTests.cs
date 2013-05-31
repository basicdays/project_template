using AutoMapper;
using BuildHealth2013.WebUI.Infrastructure.AutoMapper;
using BuildHealth2013.WebUI.Infrastructure.StructureMap;
using NUnit.Framework;
using StructureMap;

namespace BuildHealth2013.IntegrationTests.Ioc
{
	[TestFixture]
	public class AutoMapperTests
	{
		[Test]
		public void CanSetupAutoMapper()
		{
			//arrange
			var container = new Container();
            new StructuremapRegistrar().ConfigureDependencies(container);
			var mapperTask = container.GetInstance<AutoMapperTask>();

			//act
			mapperTask.Bootstrap();

			//assert
			Mapper.AssertConfigurationIsValid();
		}
	}
}
