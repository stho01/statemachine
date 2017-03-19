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
    public class MainMenuState : BaseMenuState
    {
        protected override IEnumerable<IMenuOption> ConstructMenuOptions()
        {
            yield return new MenuOption("1", "Start Counting", StartCounting);
            yield return new MenuOption("2", "Settings", Settings);
            yield return new ExitOption("3");
        }
        
        //******************************************************
        //** Menu functions
        //******************************************************

        private static void StartCounting(IApplication app)
        {
            //Console.WriteLine("So you want to count... 1,2,3,... and so on??? lol");
            app.GetFSM().ChangeState(new CountingState());
        }

        private static void Settings(IApplication app)
        {
            Console.WriteLine("Tricked you... No Settings here.");
        }
    }
}
