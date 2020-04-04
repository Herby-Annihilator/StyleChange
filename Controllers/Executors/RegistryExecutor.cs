using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace StyleChange.Controllers.Executors
{
    /// <summary>
    /// Объект инкапсулирует в себе раздел реестра, отвечающий за работу StyleChange
    /// </summary>
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
        private RegistryKey styleChange;





        /// <summary>
        /// этот класс является записью в реестре
        /// </summary>
        private class RegistryNote
        {
            
            
            
        }
    }

}
