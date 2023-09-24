using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KmnlkUMSEngine.Models
{
    public class clsUser : KmnlkUMSModel
    {
        public string fldUid { set; get; }
        public string fldDefaultPositionUid { set; get; }
        public string fldName { set; get; }
        public string fldPassword { set; get; }
        public byte[] fldDigitalSignatureImage { set; get; }
        public string fldNote { set; get; }
        public int fldFlags { set; get; }
        public int fldBlocked { set; get; }
        public string fldLastLogin { set; get; }
        public string fldCreated { set; get; }
        public string fldUpdated { set; get; }

        public clsPosition fldDefaultPosition { set; get; }
        public List<clsUserAttachment> attachments { set; get; }
        public List<clsUserContact> contacts { set; get; }
        public List<clsUserMac> macs { set; get; }

        public List<clsUserNote> notes { set; get; }
        public List<clsUserPosition> positions { set; get; }
        public List<clsRolePositionNote> rolepositionnotes { set; get; }
        public List<clsRolePositionAttachment> rolepositionattachments { set; get; }
        public List<clsDepartmentPositionNote> departmentpositionnotes { set; get; }
        public List<clsDepartmentPositionAttachment> departmentpositionattachments { set; get; }


    }
}
