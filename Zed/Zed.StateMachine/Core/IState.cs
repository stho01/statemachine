using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zed.StateMachine.Core
{
    /// <summary>
    /// A contract describing the state object. 
    /// </summary>
    /// <typeparam name="TEnitity"></typeparam>
    public interface IState<TEnitity>
    {
        /// <summary>
        /// The enter method is the first method that is called once 
        /// when ever a state is changed to this one. 
        /// </summary>
        /// <param name="entity">The owner of the state.</param>
        void Enter(TEnitity entity);

        /// <summary>
        /// The update method contains the logic for updating
        /// a state. 
        /// </summary>
        /// <param name="entity"></param>
        void Update(TEnitity entity);

        /// <summary>
        /// The exit method is the last method that is called 
        /// when ever this state is changed by another state. 
        /// </summary>
        /// <param name="entity"></param>
        void Exit(TEnitity entity);
    }
}
