using Stho.StateMachine.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramStateExample.Abstract
{
    public interface IApplication
    {
        ICoreStateMachine<IApplication> GetFSM();
        void Stop();
    }
}
