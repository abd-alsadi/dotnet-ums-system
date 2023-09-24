using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KmnlkUMSEngine.Models
{
    public class clsProfile : KmnlkUMSModel
    {
        public string fldUid { set; get; }
        public string fldUserUid { set; get; }
        public string fldEFirstName { set; get; }
        public string fldEFamilyName { set; get; }
        public string fldELocalFirstName { set; get; }
        public string fldELocalFamilyName { set; get; }
        public string fldETitle { set; get; }
        public string fldELocalTitle { set; get; }
        public string fldENickName { set; get; }
        public string fldEDisplayName { set; get; }
        public string fldLFirstName { set; get; }
        public string fldLFamilyName { set; get; }
        public string fldLLocalFirstName { set; get; }
        public string fldLLocalFamilyName { set; get; }
        public string fldLTitle { set; get; }
        public string fldLLocalTitle { set; get; }
        public string fldLNickName { set; get; }
        public string fldLDisplayName { set; get; }
        public string fldPhoneNumber { set; get; }
        public string fldEmail { set; get; }
        public string fldFax { set; get; }
        public string fldCreated { set; get; }
        public string fldUpdated { set; get; }

        public clsUser fldUser { set; get; }

        public List<clsProfileField> fields { set; get; }
      
    }
}
