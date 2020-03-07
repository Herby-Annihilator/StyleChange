using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StyleChange.Model.SPIParameters
{
    /// <summary>
    /// Предоставляет параметры обновления профиля пользователя
    /// </summary>
    [Serializable]
    internal static class UpdatingParameters
    {
        public const int UpdateINIFile = 0x01;

        public const int SendWinINIChange = 0x02;

        //public const int SendChange = 
    }
}
