using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KmnlkUMSEngine.Models
{
    public class clsRolePosition : KmnlkUMSModel
    {
         public string fldUid { set; get; }
        public string fldPositionUid { set; get; }
        public string fldRoleUid { set; get; }
        public int fldFlags { set; get; }
        public string fldCreated { set; get; }
        public string fldUpdated { set; get; }
        public int fldDeleted { set; get; }

        public clsPosition fldPosition { set; get; }
        public clsRole fldRole { set; get; }
        public List<clsRolePositionAttachment> attachments { set; get; }
        public List<clsRolePositionNote> notes { set; get; }
    }
}
