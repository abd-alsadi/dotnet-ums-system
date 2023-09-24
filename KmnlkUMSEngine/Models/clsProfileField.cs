using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KmnlkUMSEngine.Models
{
    public class clsProfileField : KmnlkUMSModel
    {
        public string fldUid { set; get; }
        public string fldProfileUid { set; get; }
        public string fldType { set; get; }
        public int fldFlags { set; get; }
        public int fldIsRequired { set; get; }
        public string fldName { set; get; }
        public string fldValue { set; get; }
        public string fldEDisplayName { set; get; }
        public string fldLDisplayName { set; get; }
        public string fldCreated { set; get; }
        public string fldUpdated { set; get; }

        public clsProfile fldProfile { set; get; }
    }
}
