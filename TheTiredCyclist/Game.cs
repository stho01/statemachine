using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TheTiredCyclist.Entities;
using TheTiredCyclist.States.CyclistStates;
using Stho.StateMachine;

namespace TheTiredCyclist
{
    public class Game
    {
        /// <summary>
        /// The only game instance in this program. 
        /// </summary>
        public static readonly Game Instance = new Game();

        //******************************************************
        //** Fields
        //******************************************************
        public bool exit = false;
        public Cyclist cyclist;
        
        /// <summary>
        /// Private constructor cus this is a singleton..
        /// </summary>
        private Game()
        {

        }
        
        public Game Init()
        {
            Console.SetWindowSize(Console.LargestWindowWidth/2, Console.LargestWindowHeight/2);

            var cyclistStateMachine = new DefaultStateMachine<Cyclist>();
            cyclistStateMachine.SetCurrentState(new RestedAndTimeToTrainState(1));
            cyclist = new Cyclist(cyclistStateMachine);
            cyclist.Name = "Froome";

            return Instance;
        }
        
        public void Run()
        {
            while(!exit)
            {
                cyclist.GetFSM().Update();
                Thread.Sleep(200);
            }
        }

        public void Exit() => exit = true;
        

        public void Update()
        {
            
        }
    }
}
