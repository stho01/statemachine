using Stho.StateMachine.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stho.StateMachine
{
    public class SimpleStateMachine<TEntity> : ICoreStateMachine<TEntity>
    {
        //******************************************************
        //**  Properties
        //******************************************************

        /// <summary>
        /// Current active state. 
        /// </summary>
        public IState<TEntity> CurrentState { get; private set; }

        //******************************************************
        //** Private fields
        //******************************************************

        /// <summary>
        /// The owner of the state machine
        /// </summary>
        private TEntity _owner;

        /// <summary>
        /// Unloads current state 
        /// enters new state. 
        /// </summary>
        /// <param name="state"></param>
        public void ChangeState(IState<TEntity> state)
        {
            CurrentState?.Exit(_owner);
            CurrentState = state;
            CurrentState?.Enter(_owner);
        }

        /// <summary>
        /// Sets the current state without any exit or enter method being called. 
        /// </summary>
        /// <param name="state"></param>
        public void SetCurrentState(IState<TEntity> state) => CurrentState = state;
        
        /// <summary>
        /// Sets the owner of this state machine
        /// </summary>
        /// <param name="owner"></param>
        public void SetOwner(TEntity owner) => _owner = owner;
    }
}
