using KmnlkCommon.Shareds;
using KmnlkUMSEngine.Connections;
using KmnlkUMSEngine.Managers;
using KmnlkUMSEngine.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static KmnlkCommon.Shareds.LoggerManagement;

namespace MyTest
{
    class Program
    {
        static void Main(string[] args)

       {
 
            string aaa = "hellow";
            var xxxxxx=EncDecManagement.AES.encryptData("abd", "keykey");
            var bbb= EncDecManagement.AES.decryptData(xxxxxx, "keykey");
            var bbbaaa = EncDecManagement.AES.encryptData(xxxxxx, "keykey1");
            //commit
        }
    }
}
