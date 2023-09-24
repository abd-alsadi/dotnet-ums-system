using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KmnlkUMSEngine.Models
{
    public class clsDepartmentPrivilage : KmnlkUMSModel
    {
        public string fldUid { set; get; }
        public string fldPrivilageUid { set; get; }
        public string fldDepartmentUid { set; get; }
        public int fldFlags { set; get; }
        public decimal fldAttributes { set; get; }
        public string fldCreated { set; get; }
        public string fldUpdated { set; get; }

        public clsPrivilage fldPrivilage { set; get; }
        public clsDepartment fldDepartment { set; get; }
    }
}
