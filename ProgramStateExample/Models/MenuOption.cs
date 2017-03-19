using ProgramStateExample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramStateExample.Models
{
    public class MenuOption : IMenuOption
    {
        public virtual IEnumerable<string> Commands { get; }
        public virtual string Name { get; }
        public virtual Action<IApplication> Run { get; }


        //******************************************************
        //** Ctors
        //******************************************************

        public MenuOption(string cmd, string name, Action<IApplication> run) : this(new List<string>() { cmd }, name, run) {}

        public MenuOption(IEnumerable<string> cmds, string name, Action<IApplication> run)
        {
            Commands = cmds;
            Name = name;
            Run = run;
        }
    }
}
