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
    public class Program
    {
        
        /// <summary>
        /// The program entry method
        /// </summary>
        /// <param name="args"></param>
        internal static void Main(string[] args)
        {
            var app = new Application();
            app.Start();
        }
    }
}
