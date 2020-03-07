using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StyleChange.Controllers.Executors;

namespace StyleChange.Model.Commands
{
    /// <summary>
    /// Абстрактный класс "Команда" определяет общий интерфейс для семейства исполняемых команд приложения StyleChange
    /// </summary>
    [Serializable]
    public abstract class Command
    {
        /// <summary>
        /// Метод возвращает ИСТИНА только в том случае, если эта команда изменила состояние системы (например, поменяла обои рабочего стола).
        /// Выполняет текущую команду
        /// </summary>
        /// <returns></returns>
        public abstract bool Execute();

        /// <summary>
        /// Представляет строку команды в консоли, которую необходимо ввести для активации этой команды
        /// </summary>
        public virtual string CommandText { get; }

        /// <summary>
        /// Предоставляет список исполнителей данной команды
        /// </summary>
        public virtual Executor[] Executors { get; protected set; }

        Command()
        {

        }
        //================================================
        //  Подумать над структурой отмены действий
        //================================================
    }
}
