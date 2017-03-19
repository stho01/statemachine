using ProgramStateExample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramStateExample.Models
{
    public class ExitOption : IMenuOption
    {
        //******************************************************
        //** Default exit cmds 
        //******************************************************

        private static IList<string> DefaultExitCmds = new List<string>()
        {
            "Exit",
            "exit",
            "Quit",
            "quit"
        };

        public IEnumerable<string> Commands { get; }

        /// <summary>
        /// Exit..
        /// </summary>
        public string Name => "Exit";

        /// <summary>
        /// Stops the application
        /// </summary>
        public Action<IApplication> Run => (app) => app.Stop();
        
        //******************************************************
        //** Ctors
        //******************************************************
        
        public ExitOption(string cmd)
            : this(new List<string> { cmd }) { }

        public ExitOption(IEnumerable<string> cmds)
        {
            Commands = cmds;
        }
    }
}
