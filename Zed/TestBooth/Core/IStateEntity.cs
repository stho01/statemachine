using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zed.StateMachine.Core;

namespace TestBooth.Core
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
