using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KmnlkUMSEngine.Models
{
    public class clsUserMac : KmnlkUMSModel
    {
        public string fldUid { set; get; }
        public string fldUserUid { set; get; }
        public int fldFlags { set; get; }
        public int fldStatus { set; get; }
        public string fldMacAddress { set; get; }
        public string fldCreated { set; get; }
        public string fldUpdated { set; get; }
        public clsUser fldUser { set; get; }
    }
}
