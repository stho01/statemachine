using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramStateExample.Abstract
{
    public interface IMenuOption
    {
        IEnumerable<string> Commands { get; }
        string Name { get; }
        Action<IApplication> Run { get; }
    }
}
