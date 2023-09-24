using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KmnlkUMSEngine.Models
{
    public class clsRole : KmnlkUMSModel
    {
        public string fldUid { set; get; }
        public string fldPositionManagerUid { set; get; }
        public string fldEName { set; get; }
        public string fldLName { set; get; }
        public string fldNote { set; get; }
        public int fldFlags { set; get; }
        public string fldCreated { set; get; }
        public string fldUpdated { set; get; }

        public clsPosition fldPositionManager { set; get; }
        public List<clsRolePrivilage> privilages { set; get; }
        public List<clsRoleResponsipility> responsipilites { set; get; }
        public List<clsRoleContact> contacts { set; get; }
        public List<clsRolePosition> positions { set; get; }
    }
}
