using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramStateExample.Abstract;
using ProgramStateExample.Models;

namespace ProgramStateExample.States
{
    public class SettingsMenuState : BaseMenuState
    {
        protected override IEnumerable<IMenuOption> ConstructMenuOptions()
        {
            yield return new MenuOption("1", "", (IApplication app) => { });
            yield return new MenuOption("2", "", (IApplication app) => { });
            yield return new MenuOption("3", "", (IApplication app) => { });
        }
    }
}
