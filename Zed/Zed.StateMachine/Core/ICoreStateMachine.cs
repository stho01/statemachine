using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zed.StateMachine.Core
{
    /// <summary>
    /// A contract describing a core state machine.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface ICoreStateMachine<TEntity>
    {
        /// <summary>
        /// 
        /// </summary>
        void SetOwner(TEntity owner);

        /// <summary>
        /// The current state is a reference to the current active state.
        /// This reference can ofc. change, and should be changed in the ChangeState method. 
        /// </summary>
        IState<TEntity> CurrentState { get; }

        /// <summary>
        /// Sets the current state.
        /// </summary>
        /// <param name="state"></param>
        void SetCurrentState(IState<TEntity> state);

        /// <summary>
        /// Changes the state 
        /// </summary>
        /// <param name="state"></param>
        void ChangeState(IState<TEntity> state);
    }
}
