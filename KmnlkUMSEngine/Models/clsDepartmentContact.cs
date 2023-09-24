using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KmnlkUMSEngine.Models
{
    public class clsDepartmentContact : KmnlkUMSModel
    {
        public string fldUid { set; get; }
        public string fldDepartmentUid { set; get; }
        public string fldType { set; get; }
        public int fldFlags { set; get; }
        public string fldName { set; get; }
        public string fldEmail { set; get; }
        public string fldPhoneNumber { set; get; }
        public string fldFax { set; get; }
        public int fldStatus { set; get; }
        public string fldNote { set; get; }
        public string fldCreated { set; get; }
        public string fldUpdated { set; get; }

        public clsDepartment fldDepartment { set; get; }
    }
}
