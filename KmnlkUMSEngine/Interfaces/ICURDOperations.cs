using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KmnlkUMSEngine.Interfaces
{
     interface ICURDOperations
    {
        int Insert(KmnlkUMSModel model);
        int Update(KmnlkUMSModel model);
        int Delete(KmnlkUMSModel model);
        KmnlkUMSModel Get(KmnlkUMSModel model);
        List<KmnlkUMSModel> All(KmnlkUMSModel model);
        List<KmnlkUMSModel> Find(int size,int page,KmnlkUMSModel model);
    }
}
