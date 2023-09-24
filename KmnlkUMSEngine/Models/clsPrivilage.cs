using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KmnlkUMSEngine.Models
{
    public class clsPrivilage : KmnlkUMSModel
    {
        public string fldUid { set; get; }
        public string fldEName { set; get; }
        public string fldLName { set; get; }
        public decimal fldprivilageNumber { set; get; }
        public decimal fldType { set; get; }
        public string fldNote { set; get; }
        public int fldFlags { set; get; }
        public string fldCreated { set; get; }
        public string fldUpdated { set; get; }

        public List<clsRolePrivilage> roles { set; get; }
        public List<clsDepartmentPrivilage> departments { set; get; }
        public List<clsPositionPrivilage> positions { set; get; }

    }
}
