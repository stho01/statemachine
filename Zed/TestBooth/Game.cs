using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestBooth.Entities;
using Zed.StateMachine;

namespace TestBooth
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

        public Cyclist cyclist = new Cyclist(new DefaultStateMachine<Cyclist>());

        /// <summary>
        /// Private constructor cus this is a singleton..
        /// </summary>
        private Game()
        {

        }
        
        public Game Initialise()
        {

            return Instance;
        }
        
        public void Run()
        {

        }

        public void Update()
        {
            
        }
    }
}
