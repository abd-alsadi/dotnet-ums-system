using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KmnlkUMSEngine.Models
{
    public class clsRolePositionAttachment : KmnlkUMSModel
    {
        public string fldUid { set; get; }
        public string fldRolePositionUid { set; get; }
        public string fldUserUid { set; get; }
        public string fldType { set; get; }
        public int fldFlags { set; get; }
        public string fldFilePath { set; get; }
        public string fldFileCaption { set; get; }
        public string fldFileExt { set; get; }
        public string fldNote { set; get; }
        public string fldCreated { set; get; }
        public string fldUpdated { set; get; }

        public clsRolePosition fldRolePosition { set; get; }
        public clsUser fldUser { set; get; }
    }
}
