using KmnlkUMSEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static KmnlkUMSDll.Constants.Enums;

namespace KmnlkUMSDll.Interfaces
{
     interface ICURDOperations
    {
        Enum_CURD_Result Insert(KmnlkUMSModel model);
        Enum_CURD_Result Update(KmnlkUMSModel model);
        Enum_CURD_Result Delete(KmnlkUMSModel model);
        KmnlkUMSModel Get(KmnlkUMSModel model);
        List<KmnlkUMSModel> All(KmnlkUMSModel model);
        List<KmnlkUMSModel> Find(int size,int page,KmnlkUMSModel model);
    }
}
