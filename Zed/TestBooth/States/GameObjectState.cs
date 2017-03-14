using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestBooth.Entities;
using Zed.StateMachine.Core;

namespace TestBooth.States
{
    public abstract class GameObjectState<T> : IState<T>
        where T : GameObject
    {
        public abstract void Enter(T entity);
        public abstract void Exit(T entity);
        public abstract void Update(T entity);

        /// <summary>
        /// Let the entity talk or basically 
        /// write to the console.
        /// </summary>
        /// <param name="entity"></param>
        protected void Talk(T entity, string msg)
        {
            Console.WriteLine($"[{DateTime.Now.ToShortTimeString()}] {entity.Name, 30} : {msg}");
        }
    }
}
