using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KmnlkUMSEngine.Models
{
    public class clsPositionPrivilage : KmnlkUMSModel
    {
        public string fldUid { set; get; }
        public string fldPrivilageUid { set; get; }
        public string fldPositionUid { set; get; }
        public int fldFlags { set; get; }
        public decimal fldAttributes { set; get; }
        public string fldCreated { set; get; }
        public string fldUpdated { set; get; }

        public clsPrivilage fldPrivilage { set; get; }
        public clsPosition fldPosition { set; get; }
    }
}
