using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace KmnlkUMSEngine.Models
{
    //[DataContract] [DataMember(Name ="")]
    public class clsDelegation : KmnlkUMSModel
    {
        public string fldUid { set; get; }
        public string fldFromUserUid { set; get; }
        public string fldToUserUid { set; get; }
        public string fldFromDate { set; get; }
        public string fldFromTime { set; get; }
        public string fldToDate { set; get; }
        public string fldToTime { set; get; }
        public int fldIsActive { set; get; }
        public int fldFlags { set; get; }
        public string fldNote { set; get; }
        public string fldCreated { set; get; }
        public string fldUpdated { set; get; }
        public clsUser fldFromUser { set; get; }
        public clsUser fldToUser { set; get; }
    }
}
