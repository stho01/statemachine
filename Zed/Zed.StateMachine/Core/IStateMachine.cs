using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stho.StateMachine.Core
{
    /// <summary>
    /// A contract describing a state machine
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IStateMachine<TEntity> : ICoreStateMachine<TEntity>
    {
        /// <summary>
        /// The global state is a state that if not null
        /// always should update. The global state is typically used for
        /// frequently called checks which can contribute to a current state change. 
        /// </summary>
        IState<TEntity> GlobalState { get; }
        
        /// <summary>
        /// The previous state is a reference to the previously active state. 
        /// </summary>
        IState<TEntity> PreviousState { get; }

        /// <summary>
        /// Set global state. 
        /// </summary>
        /// <param name="state"></param>
        void SetGlobalState(IState<TEntity> state);
        
        /// <summary>
        /// Set the previous state. 
        /// </summary>
        /// <param name="state"></param>
        void SetPreviousState(IState<TEntity> state);
    }
}
