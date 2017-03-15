using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stho.StateMachine.Core;

namespace TheTiredCyclist.Core
{
    /// <summary>
    /// 
    /// </summary>
    public interface IStateEntity : IEntity
    {
        IUpdatableStateMachine<IStateEntity> GetFSM();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IStateEntity<T> : IEntity
        where T : IStateEntity<T>
    {
        IUpdatableStateMachine<T> GetFSM();
    }
}
