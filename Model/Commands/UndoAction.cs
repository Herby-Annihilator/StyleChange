using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StyleChange.Controllers.Executors;

namespace StyleChange.Model.Commands
{
    /// <summary>
    /// Отменяет предыдущее действие, если это возможно
    /// </summary>
    public class UndoAction : Command
    {
        public override string CommandText
        {
            get
            {
                return "undo";
            }
        }

        public override Executor[] Executors { get => null; protected set => base.Executors = null; }
        protected override void CreateSnapshot()
        {
            throw new NotImplementedException();
        }

        public override bool Execute()
        {
            if (callStack.IsEmpty())
                return false;
            else
                return callStack.PopCommand().Execute();
        }
    }
}
