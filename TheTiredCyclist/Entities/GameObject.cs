using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheTiredCyclist.Core;
using Stho.StateMachine.Core;

namespace TheTiredCyclist.Entities
{
    public class GameObject : IEntity
    {
        public Guid Id { get; }
        public string Name { get; set; }
        
        public GameObject()
        {
            Id = Guid.NewGuid();
        }
    }
}
