using ProgramStateExample.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ProgramStateExample.Collections
{
    public class MenuOptionCollection : IEnumerable<IMenuOption>
    {
        
            
        public IEnumerator<IMenuOption> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
