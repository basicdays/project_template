using System.Collections.Generic;

namespace BuildHealth2013.WebUI.App_Start.BootStrap
{
	public interface IDependencyRegistrar
	{
		void ConfigureDependencies();

		IEnumerable<IBootstrapTask> ResolveStartupTasks();
	}
}
