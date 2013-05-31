using System.Reflection;
using BuildHealth2013.WebUI.Infrastructure.StructureMap;
using BuildHealth2013.WebUI.Infrastructure.StructureMap.Bootstrap;
using StructureMap;
using log4net;

namespace BuildHealth2013.WebUI
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        private Bootstrap _bootstrapper;

        protected void Application_Start()
        {
            //start log4net
            var logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

            _bootstrapper =
                new Bootstrap()
                    .WithContainer(ObjectFactory.Container)
                    .WithRegistrar(new StructuremapRegistrar())
                    .WithLogger(logger)
                    .Start();
        }

        protected void Application_End()
        {
            _bootstrapper.Dispose();
        }
    }
}