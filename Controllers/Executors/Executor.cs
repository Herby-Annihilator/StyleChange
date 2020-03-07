using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StyleChange.Controllers.Executors
{
    public abstract class Executor
    {
        public virtual string Name { get; protected set; }
    }
}
