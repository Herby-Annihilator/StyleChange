using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace StyleChange.Controllers.Executors
{
    public class RegistryExecutor : Executor
    {
        public override string Name
        {
            get
            {
                return "Registry Executor";
            }
        }

        //
        // проверить, существует ли запись в реестре, причем проверить надо все (рекурсивно)
        //
    }
}
