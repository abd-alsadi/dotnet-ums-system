using KmnlkUMSSite.Constants;
using KmnlkUMSSite.Management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KmnlkUMSSite.Helpers
{
    public class MainHelper
    {
        public static string getUrlAPI(string controller="",string action = "")
        {
            string url = SettingsManagement.getSetting(SettingsManagement.KEY_UMSApiService).ToString();
            if (url == null)
                url = "";

            if (controller != "")
                url += URLS_UMS_API.USER_CONTROLLER;

            if(action!="")
                url+= "/" + URLS_UMS_API.USER_ALL_ACTION;

            return url;
        }
    }
}