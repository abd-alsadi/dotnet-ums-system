using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KmnlkUMSEngine.Models
{
    public class clsDepartment : KmnlkUMSModel
    {
        public string fldUid { set; get; }
        public string fldParentUid { set; get; }
        public string fldPositionManagerUid { set; get; }
        public string fldEName { set; get; }
        public string fldLName { set; get; }
        public int fldGrade { set; get; }
        public string fldCode { set; get; }
        public string fldNote { set; get; }
        public string fldLevel { set; get; }
        public string fldFax { set; get; }
        public string fldParentCode { set; get; }
        public int fldFlags { set; get; }
        public string fldCreated { set; get; }
        public string fldUpdated { set; get; }

        public clsDepartment fldParent { set; get; }
        public clsPosition fldPositionManager { set; get; }

        public List<clsDepartmentContact> contacts { set; get; }
        public List<clsDepartmentResponsipility> responsipileties { set; get; }
        public List<clsDepartmentPrivilage> privilages { set; get; }
        public List<clsDepartmentPosition> positions { set; get; }
    }
}
