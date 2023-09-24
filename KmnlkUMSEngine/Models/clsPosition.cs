using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KmnlkUMSEngine.Models
{
    public class clsPosition : KmnlkUMSModel
    {
        public string fldUid { set; get; }
        public string fldUserManagerUid { set; get; }
        public string fldName { set; get; }
        public string fldEName { set; get; }
        public string fldLName { set; get; }
        public string fldGrade { set; get; }
        public string fldNote { set; get; }
        public int fldFlags { set; get; }
        public int fldBlocked { set; get; }
        public string fldCreated { set; get; }
        public string fldUpdated { set; get; }

        public clsUser fldUserManager { set; get; }

        public List<clsUserPosition> users { set; get; }
        public List<clsUserContact> contacts { set; get; }
        public List<clsPositionResponsipility> responsipilites { set; get; }
        public List<clsDepartmentPosition> departments { set; get; }
        public List<clsPositionPrivilage> privilages { set; get; }
        public List<clsRolePosition> roles { set; get; }

    }
}
