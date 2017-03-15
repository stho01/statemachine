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
    public interface IStateMachine<TEntity> : IStateMachine<TEntity, IState<TEntity>> { }

    /// <summary>
    /// A contract describing a state machine
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <typeparam name="TStateType"></typeparam>
    public interface IStateMachine<TEntity, TStateType> : ICoreStateMachine<TEntity, TStateType>
        where TStateType : IState<TEntity>
    {
        /// <summary>
        /// The global state is a state that if not null
        /// always should update. The global state is typically used for
        /// frequently called checks which can contribute to a current state change. 
        /// </summary>
        TStateType GlobalState { get; }

        /// <summary>
        /// The previous state is a reference to the previously active state. 
        /// </summary>
        TStateType PreviousState { get; }

        /// <summary>
        /// Set global state. 
        /// </summary>
        /// <param name="state"></param>
        void SetGlobalState(TStateType state);
        
        /// <summary>
        /// Set the previous state. 
        /// </summary>
        /// <param name="state"></param>
        void SetPreviousState(TStateType state);
    }
}
