using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stho.StateMachine.Core
{
    public interface IUpdateableState<TEntity> : IState<TEntity>
    {
        /// <summary>
        /// The update method contains the logic for updating
        /// a state. 
        /// </summary>
        /// <param name="entity"></param>
        void Update(TEntity entity);
    }
}
