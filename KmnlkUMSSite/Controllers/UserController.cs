
using KmnlkCommon.Shareds;
using KmnlkUMSSite.Constants;
using KmnlkUMSSite.Exceptions;
using KmnlkUMSSite.Helpers;
using KmnlkUMSSite.Management;
using KmnlkUMSSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Mvc;
using static KmnlkCommon.Shareds.LoggerManagement;

namespace KmnlkUMSSite.Controllers
{
    public class UserController : Controller
    {
        private PackageManagement package = new PackageManagement();

        public ActionResult Index()
        {
            return View();
        }
 
        public async Task<string> GetUsers()
        {
            try {
                var obj = CacheManagement.getFromCache("GetUsers", "USER",null);
                ResponseModel data = null;
                if (obj==null)
                {
                    string url = MainHelper.getUrlAPI("User", "All"); 
                    var requestUrl = WebClientManagement.CreateRequestUri(url);
                     data = await WebClientManagement.GetAsync<ResponseModel>(requestUrl);
                    CacheManagement.addToCache("GetUsers", "USER", data, true, 1);
                }
                else
                {
                     data = (ResponseModel) obj;
                }
                 package.context.logger.WriteToLog(EnvironmentManagement.getCurrentMethodName(this.GetType()), "", ENUM_TYPE_MSG_LOGGER.INFO,ENUM_TYPE_Block_LOGGER.END, modConstants.MSG_SUCCESS);
                return  JsonManagement.toJson(data);
            }
            catch(Exception e)
            {
                new SiteException(package.context.logger, "", EnvironmentManagement.getCurrentMethodName(this.GetType()), e.Message);
                return null;
            }
      
        }
    }
}
