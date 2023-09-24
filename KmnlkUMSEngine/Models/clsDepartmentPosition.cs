using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KmnlkUMSEngine.Models
{
    public class clsDepartmentPosition : KmnlkUMSModel
    {
        public string fldUid { set; get; }
        public string fldPositionUid { set; get; }
        public string fldDepartmentUid { set; get; }
        public int fldFlags { set; get; }
        public string fldCreated { set; get; }
        public string fldUpdated { set; get; }
        public int fldDeleted { set; get; }

        public clsPosition fldPosition { set; get; }
        public clsDepartment fldDepartment { set; get; }

        public List<clsDepartmentPositionAttachment> attachments { set; get; }
        public List<clsDepartmentPositionNote> notes { set; get; }
    }
}
