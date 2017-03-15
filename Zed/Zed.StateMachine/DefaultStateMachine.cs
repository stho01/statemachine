using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stho.StateMachine.Core;

namespace Stho.StateMachine
{
    /// <summary>
    /// A default implementation of a state machine  
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public class DefaultStateMachine<TEntity> : IStateMachine<TEntity>
    {
        //******************************************************
        //** Properties
        //******************************************************

        /// <summary>
        /// The current state is a reference to the current active state.
        /// This reference can ofc. change, and should be changed in the ChangeState method. 
        /// </summary>
        public IState<TEntity> CurrentState { get; private set; }

        /// <summary>
        /// The global state is a state that if not null
        /// always should update. The global state is typically used for
        /// frequently called checks which can contribute to a current state change. 
        /// </summary>
        public IState<TEntity> GlobalState { get; private set; }

        /// <summary>
        /// The previous state is a reference to the previously active state. 
        /// </summary>
        public IState<TEntity> PreviousState { get; private set; }
        
        //******************************************************
        //** Fields
        //******************************************************
        
        /// <summary>
        /// Holds a reference of the owner of the state machine. 
        /// </summary>
        private TEntity _owner;
        
        //******************************************************
        //** Constructor
        //******************************************************
        
        public DefaultStateMachine()
        {
            
        }

        //******************************************************
        //** Public API.
        //******************************************************

        /// <summary>
        /// 
        /// </summary>
        /// <param name="owner"></param>
        /// <returns></returns>
        public void SetOwner(TEntity owner) => _owner = owner;
        
        /// <summary>
        /// Changes the state 
        /// Calls exit on current state and enter of the new state is called. 
        /// </summary>
        /// <param name="state"></param>
        public void ChangeState(IState<TEntity> state)
        {
            if (state == null)
                throw new NullReferenceException("state can not be null");

            if (CurrentState != null)
            {
                CurrentState.Exit(_owner);
                PreviousState = CurrentState;
            }
            CurrentState = state;
            CurrentState.Enter(_owner);
        }

        /// <summary>
        /// Sets the current state.
        /// </summary>
        /// <param name="state"></param>
        public void SetCurrentState(IState<TEntity> state)
        {
            CurrentState = state;
        }

        /// <summary>
        /// Set global state. 
        /// </summary>
        /// <param name="state"></param>
        public void SetGlobalState(IState<TEntity> state)
        {
            GlobalState = state;
        }

        /// <summary>
        /// Set the previous state. 
        /// </summary>
        /// <param name="state"></param>
        public void SetPreviousState(IState<TEntity> state)
        {
            PreviousState = state;
        }

        /// <summary>
        /// Updates current active states.
        /// </summary>
        public void Update()
        {
            if (_owner != null)
            {
                GlobalState?.Update(_owner);
                CurrentState?.Update(_owner);
            }
        }
    }
}
