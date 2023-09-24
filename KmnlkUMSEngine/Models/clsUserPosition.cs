using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KmnlkUMSEngine.Models
{
    public class clsUserPosition : KmnlkUMSModel
    {
        public string fldUid { set; get; }
        public string fldPositionUid { set; get; }
        public string fldUserUid { set; get; }
        public int fldDeleted { set; get; }
        public int fldFlags { set; get; }
        public string fldCreated { set; get; }
        public string fldUpdated { set; get; }

        public clsPosition fldPosition { set; get; }
        public clsUser fldUser { set; get; }

        List<clsUserPositionNote> notes { set; get; }
        List<clsUserPositionAttachment> attachments { set; get; }
    }
}
