using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stho.StateMachine.Core;

namespace TheTiredCyclist.Core
{
    public interface IStateEntity : IEntity
    {
        IStateMachine<IStateEntity> GetFSM();
    }

    public interface IStateEntity<T> : IEntity
        where T : IStateEntity<T>
    {
        IStateMachine<T> GetFSM();
    }
}
