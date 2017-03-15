using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stho.StateMachine.Core
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <typeparam name="TStateType"></typeparam>
    public interface IUpdatableStateMachine<TEntity> : ICoreStateMachine<TEntity, IUpdateableState<TEntity>>
    {
        /// <summary>
        /// Updates current active states.
        /// </summary>
        void Update();
    }
}
