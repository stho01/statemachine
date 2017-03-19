using ProgramStateExample.Abstract;
using ProgramStateExample.States;
using Stho.StateMachine;
using Stho.StateMachine.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramStateExample
{
    public class Application : IApplication
    {
        //******************************************************
        //** Fields
        //******************************************************

        /// <summary>
        /// State machine controlling the current state of the application
        /// </summary>
        private ICoreStateMachine<IApplication> _programState;
        
        //******************************************************
        //** Ctor
        //******************************************************
        
        public Application()
        {
            Console.WriteLine("Application constructed...");
            _programState = new SimpleStateMachine<IApplication>(this);
            _programState.SetCurrentState(new MainMenuState());
        }
    
        //******************************************************
        //** Public API
        //******************************************************
        
        /// <summary>
        /// Get the state machine controlling the states of the application.
        /// </summary>
        /// <returns></returns>
        public ICoreStateMachine<IApplication> GetFSM() => _programState;
       
        /// <summary>
        /// Start the application 
        /// </summary>
        public void Start()
        {
            _programState.CurrentState.Enter(this);
            Console.WriteLine("Application started...");
        }

        /// <summary>
        /// Exit the application 
        /// </summary>
        public void Stop()
        {
            Console.WriteLine("Application stopped...");
            Environment.Exit(0);
        }
    }
}
