using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KmnlkUMSEngine.Models
{
    public class clsSetting : KmnlkUMSModel
    {
        public string fldUid { set; get; }
        public string fldName { set; get; }
        public string fldValue { set; get; }
        public string fldNote { set; get; }
        public int fldFlags { set; get; }
        public string fldCreated { set; get; }
        public string fldUpdated { set; get; }
    }
}
