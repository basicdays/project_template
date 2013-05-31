using System;

namespace BuildHealth2013.WebUI.App_Start.BootStrap
{
	/// <summary>
	/// Bootstrap foundation class that ensure a bootstrap process occurs only once.
	/// </summary>
	public interface IBootstrapper : IDisposable
	{
		/// <summary>
		/// Call to begin bootstrapping. Can only be run once.
		/// </summary>
		IBootstrapper Bootstrap();
	}
}
