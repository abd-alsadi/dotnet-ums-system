using KmnlkUMSEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KmnlkUMSDll.Interfaces
{
    public interface IValidationOperations
    {
        bool isValid(KmnlkUMSModel model);
    }
}
