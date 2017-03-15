using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheTiredCyclist.Core;
using Stho.StateMachine;
using Stho.StateMachine.Core;

namespace TheTiredCyclist.Entities
{
    public class StateGameObject<T> : GameObject, IStateEntity<T>
        where T : IStateEntity<T>
    {
        //******************************************************
        //** Fields
        //******************************************************
        
        private IUpdatableStateMachine<T> _fsm;
        
        //******************************************************
        //** Ctor
        //******************************************************
        
        public StateGameObject(IUpdatableStateMachine<T> fsm)
        {
            _fsm = fsm;
        }

        //******************************************************
        //** Public API
        //******************************************************

        public IUpdatableStateMachine<T> GetFSM() => _fsm;

        public void Update()
        {
            
        }
    }
}
