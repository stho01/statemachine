using ProgramStateExample.Abstract;
using ProgramStateExample.Models;
using Stho.StateMachine.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramStateExample.States
{
    public abstract class BaseMenuState : IState<IApplication>
    {
        //protected static IMenuOption ExitOption = new MenuOption"e", "exit");

        //******************************************************
        //** Properties
        //******************************************************

        /// <summary>
        /// A map that uses the command property as a key. 
        /// </summary>
        public IDictionary<string, IMenuOption> Options { get; private set; }

        //******************************************************
        //** Abstract methods
        //******************************************************

        /// <summary>
        /// Construction method for construction the menu options.
        /// </summary>
        /// <returns></returns>
        protected abstract IEnumerable<IMenuOption> ConstructMenuOptions();
        
        //******************************************************
        //** Public methods. 
        //******************************************************

        /// <summary>
        /// Handle the base entry logic of a menu state. 
        /// </summary>
        /// <param name="entity"></param>
        public virtual void Enter(IApplication entity)
        {
            var menuOptions = ConstructMenuOptions();
            Options = CreateOptionsMap(menuOptions); /*menuOptions.ToDictionary(x => x.Command, x => x);*/
            WriteMenu(menuOptions);
            WaitForInput(entity);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        public virtual void Exit(IApplication entity) { }

        //******************************************************
        //** Private/protected methods
        //******************************************************

        protected IMenuOption ExitMenuOption(string cmd) => new ExitOption(cmd);

        /// <summary>
        /// Writes the menu.
        /// </summary>
        /// <param name="options"></param>
        protected void WriteMenu(IEnumerable<IMenuOption> options) {
            foreach (var option in options)
                Console.WriteLine($"{option.Commands.FirstOrDefault(), -5} : {option.Name}");
        }
        
        /// <summary>
        /// Let the menu wait for a leagal command. 
        /// </summary>
        private void WaitForInput(IApplication app)
        {
            bool legalCmd = false;
            while (!legalCmd)
            {
                Console.Write("> ");                            
                var cmd = Console.ReadLine();
                legalCmd = Options.Any(x => x.Key.Equals(cmd));

                if (legalCmd)
                    Options[cmd].Run?.Invoke(app);
                else
                    Console.WriteLine("Unkown command.");
            }
        }


        //******************************************************
        //** Utils
        //******************************************************

        /// <summary>
        /// Creates a map based on the commands for easily look up a function based on command. 
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public static IDictionary<string, IMenuOption> CreateOptionsMap(IEnumerable<IMenuOption> options)
        {
            var dict = new Dictionary<string, IMenuOption>();
            foreach (var option in options)
                foreach (var command in option.Commands)
                    if (!dict.ContainsKey(command))
                        dict.Add(command, option);
                    // else 
                        // TODO:  log failure. 

            return dict;
        }
    }
}
