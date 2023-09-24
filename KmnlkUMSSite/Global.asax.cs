using KmnlkUMS;
using KmnlkCommon.Shareds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace KmnlkUMSSite
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            initResources();
        }

        private void initResources()
        {
            string pathResourcesFolder = EnvironmentManagement.getRootPath() + "/Resources";
            string pathResourcesFolderJS = EnvironmentManagement.getRootPath() + "Scripts\\resources\\AllResources.js";
            ResourcesManagement.setConfiguration(pathResourcesFolder, pathResourcesFolderJS);
        }
    }
}
