using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestBooth.Core;
using Zed.StateMachine;
using Zed.StateMachine.Core;

namespace TestBooth.Entities
{
    public class StateGameObject<T> : GameObject, IStateEntity<T>
        where T : IStateEntity<T>
    {
        //******************************************************
        //** Fields
        //******************************************************
        
        private IStateMachine<T> _fsm;
        
        //******************************************************
        //** Ctor
        //******************************************************
        
        public StateGameObject(IStateMachine<T> fsm)
        {
            _fsm = fsm;
        }

        //******************************************************
        //** Public API
        //******************************************************

        public IStateMachine<T> GetFSM() => _fsm;

        public void Update()
        {
            
        }
    }
}
