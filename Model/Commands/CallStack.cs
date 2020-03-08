using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StyleChange.Model.Commands
{
    public class CallStack
    {
        /// <summary>
        /// Сдесь сохраняются все снимки команд
        /// </summary>
        private Stack<Command> commands;

        public CallStack()
        {
            commands = new Stack<Command>();
        }

        /// <summary>
        /// Сохраняет указанную команду в стек вызовов
        /// </summary>
        /// <param name="command"></param>
        public void PushCommand(Command command)
        {
            commands.Push(command);
        }

        /// <summary>
        /// Возвращает предыдущую команду из стека вызовов
        /// </summary>
        /// <returns></returns>
        public Command PopCommand()
        {
            if (commands.Count > 0)
            {
                return commands.Pop();
            }
            else
            {
                return null;
            }
        }

        public bool IsEmpty()
        {
            if (commands.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
