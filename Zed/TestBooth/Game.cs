using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBooth
{
    public class Game
    {
        /// <summary>
        /// The only game instance in this program. 
        /// </summary>
        public static readonly Game Instance = new Game();

        /// <summary>
        /// Private constructor cus this is a singleton..
        /// </summary>
        private Game()
        {

        }
        
        
        public void Run()
        {

        }
    }
}
