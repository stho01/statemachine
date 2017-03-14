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
            var truncatedName = entity.Name?.Substring(0, Math.Min(entity.Name.Length, 9));
            Console.WriteLine($"[{DateTime.Now.ToShortTimeString()}] {$"{truncatedName}.", 10} : {msg}");
        }
    }
}
