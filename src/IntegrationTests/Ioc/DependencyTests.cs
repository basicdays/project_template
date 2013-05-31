using System.Reflection;
using BuildHealth2013.WebUI.Infrastructure.StructureMap;
using NUnit.Framework;
using StructureMap;
using log4net;

namespace BuildHealth2013.IntegrationTests.Ioc
{
	[TestFixture]
	public class DependencyTests
	{
		private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		[Test]
		public void CanSetupContainer()
		{
			//arrange
			var container = new Container();
            var registrar = new StructuremapRegistrar();

			//act
			registrar.ConfigureDependencies(container);

			//assert
			container.AssertConfigurationIsValid();
			//Log.Info(container.WhatDoIHave());
		}
	}
}
