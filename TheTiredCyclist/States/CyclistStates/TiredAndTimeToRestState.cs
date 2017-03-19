using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheTiredCyclist.Entities;

namespace TheTiredCyclist.States.CyclistStates
{
    public class TiredAndTimeToRestState : GameObjectState<Cyclist>
    {
        public override void Enter(Cyclist entity)
        {
            Talk(entity, "Need to rest...");
        }

        public override void Exit(Cyclist entity)
        {
            Talk(entity, "Im rested now..");
        }

        public override void Update(Cyclist entity)
        {
            if (entity.IsRested)
            {
                var form = (entity.Stamina * entity.Fitness * 0.25);
                var intensity = Math.Max(form, 1);
                entity.GetFSM().ChangeState(new RestedAndTimeToTrainState((int)intensity));
            }
            else
            {
                entity.DecreaseFatigue();
                Talk(entity, $"ZZZzzzz.....");
            }
        }
    }
}
