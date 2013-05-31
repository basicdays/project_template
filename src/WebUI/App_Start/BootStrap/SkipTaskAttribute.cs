using System;

namespace BuildHealth2013.WebUI.App_Start.BootStrap
{
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
	public class SkipTaskAttribute : Attribute {}
}
