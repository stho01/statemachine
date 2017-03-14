using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBooth.Core
{
    /// <summary>
    /// A contract describing a simple entity.
    /// </summary>
    public interface IEntity
    {
        /// <summary>
        /// The identification of the entity.
        /// </summary>
        Guid Id { get; }

        /// <summary>
        /// The name of the entity
        /// </summary>
        string Name { get; }
    }
}
