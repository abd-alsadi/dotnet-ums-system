using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KmnlkUMSEngine.Models
{
    public class clsOperation : KmnlkUMSModel
    {
        public string fldUid { set; get; }
        public string fldEName { set; get; }
        public string fldLName { set; get; }
        public decimal fldOperationNumber { set; get; }
        public string fldNote { set; get; }
        public int fldFlags { set; get; }
        public string fldCreated { set; get; }
        public string fldUpdated { set; get; }
    }
}
