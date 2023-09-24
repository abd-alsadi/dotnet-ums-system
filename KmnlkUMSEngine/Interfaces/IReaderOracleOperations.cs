using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KmnlkUMSEngine.Interfaces
{
     public interface IReaderOracleOperations
    {
        KmnlkUMSModel Read(OracleDataReader reader);
        KmnlkUMSModel[] ReadAll(OracleDataReader reader);
    }
}
