using ProgramStateExample.Abstract;
using Stho.StateMachine.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProgramStateExample.States
{
    public class CountingState : IState<IApplication>
    {
        private bool Canceled = false;
        private int seconds = 0;
        
        public void Enter(IApplication entity)
        {
            StartWorkerThread();

            while(!Canceled)
            {
                Console.Write("> ");
                var cancel = Console.ReadLine();
                if ((Canceled = cancel.Equals("c")) == false)
                    Console.WriteLine("To cancel the counting type <c>");
            }

            entity.GetFSM().ChangeState(new MainMenuState());
        }
        
        public void Exit(IApplication entity) { }


        private void StartWorkerThread()
        {
            Task.Run(() =>
            {
                Console.WriteLine("You have initialized a counter... The program will now start count until stopped. To cancel counting type <c> and enter");
                while (!Canceled)
                {
                    Console.WriteLine(seconds);
                    Thread.Sleep(1000);
                    seconds++;
                }
            });
        }
    }
}
