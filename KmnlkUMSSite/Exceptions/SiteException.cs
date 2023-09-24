using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static KmnlkCommon.Shareds.LoggerManagement;

namespace KmnlkUMSSite.Exceptions
{
    public class SiteException : Exception
    {
        public string message;
        public string title;
        public string code;
        public string language;
        public string description;
        public ILog logger;
        
        public SiteException():base()
        {
            
        }
        public SiteException(ILog logger,string code,string title,string msg,string description="",string lang="ar"):base(msg)
        {
            this.code = code;
            this.message = msg;
            this.language = lang;
            this.title = title;
            this.logger = logger;
            this.description = description;
            executeException();
        }
        private void executeException()
        {
            logger.WriteToLog(title, description, ENUM_TYPE_MSG_LOGGER.EXCEPTION, ENUM_TYPE_Block_LOGGER.END, message);
        }
    }
}
