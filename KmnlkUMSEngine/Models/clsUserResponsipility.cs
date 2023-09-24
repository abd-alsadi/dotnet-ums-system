using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KmnlkUMSEngine.Models
{
    public class clsUserResponsipility : KmnlkUMSModel
    {
        public string fldUid { set; get; }
        public string fldUserUid { set; get; }
        public string fldEName { set; get; }
        public string fldLName { set; get; }
        public int fldIsActive { set; get; }
        public string fldCode { set; get; }
        public string fldNote { set; get; }
        public int fldFlags { set; get; }
        public char fldPriority { set; get; }
        public string fldCreated { set; get; }
        public string fldUpdated { set; get; }

        public clsUser fldUser { set; get; }
    }
}
