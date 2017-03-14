using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestBooth.Entities;

namespace TestBooth.States.CyclistStates
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
                var intensity = (int)(entity.Stamina * entity.Fatigue * 0.25);
                entity.GetFSM().ChangeState(new RestedAndTimeToTrainState(intensity));
            }
            else
            {
                entity.DecreaseFatigue();
                Talk(entity, $"ZZZzzzz..... Fatigue = {entity.Fatigue}");
            }
        }
    }
}
