using KmnlkUMSApi.Constants;
using KmnlkUMSEngine.Connections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static KmnlkCommon.Shareds.LoggerManagement;

namespace KmnlkUMSSite.Management
{
    public class PackageManagement
    {
        public ContextManagement context;
        public ILog logger;
        public PackageManagement()
        {
            string pathLog = SettingsManagement.getSetting(SettingsManagement.KEY_PathLog).ToString();
            string typeLog = SettingsManagement.getSetting(SettingsManagement.KEY_TypeLog).ToString();

            
           
            switch (typeLog.ToLower())
            {
                case "file":
                    logger = new FileLogger(pathLog);
                    break;
                case "db":
                    logger = new DBLogger(pathLog);
                    break;
                default:
                    logger = new FileLogger(pathLog);
                    break;
            }

            context = new ContextManagement(logger);
        }
    }
}