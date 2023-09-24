
using KmnlkUMSEngine.Connections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static KmnlkCommon.Shareds.LoggerManagement;
using KmnlkUMSEngine.Constants;
namespace KmnlkUMSSite.Management
{
    public class ContextManagement
    { 
        public ILog logger;

        public ContextManagement(ILog logger)
        {
            this.logger = logger;
        }
    }
}