using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using BuildHealth2013.WebUI.App_Start.BootStrap;
using BuildHealth2013.WebUI.Infrastructure.StructureMap;

namespace BuildHealth2013.WebUI.App_Start
{
    public class WebUITask : IBootstrapTask
    {
        private readonly StructureMapDependencyResolver _resolver;

        public WebUITask(StructureMapDependencyResolver resolver)
        {
            _resolver = resolver;
        }

        public int Order { get { return 1; } }

        public void Bootstrap()
        {
            DependencyResolver.SetResolver(_resolver);
            GlobalConfiguration.Configuration.DependencyResolver = _resolver;

            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterAuth();

            HtmlHelper.ClientValidationEnabled = true;
            HtmlHelper.UnobtrusiveJavaScriptEnabled = true;
        }
    }
}