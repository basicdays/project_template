using System.Reflection;
using NUnit.Framework;
using log4net;

namespace BuildHealth2013.IntegrationTests
{
	[SetUpFixture]
	public class GlobalEvents
	{
		[SetUp]
		public void SetUp()
		{
			//setup log4net
			LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		}
	}
}
