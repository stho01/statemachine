using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stho.StateMachine.Core
{
    /// <summary>
    /// A contract describing the state object. 
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IState<TEntity>
    {
        /// <summary>
        /// The enter method is the first method that is called once 
        /// when ever a state is changed to this one. 
        /// </summary>
        /// <param name="entity">The owner of the state.</param>
        void Enter(TEntity entity);


        /// <summary>
        /// The exit method is the last method that is called 
        /// when ever this state is changed by another state. 
        /// </summary>
        /// <param name="entity"></param>
        void Exit(TEntity entity);
    }
}
