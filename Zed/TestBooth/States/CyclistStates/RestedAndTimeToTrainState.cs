using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestBooth.Entities;
using TestBooth.Utils;
using Zed.StateMachine.Core;

namespace TestBooth.States.CyclistStates
{
    public class RestedAndTimeToTrainState : GameObjectState<Cyclist>
    {
        //******************************************************
        //** Constants and readonly fields
        //******************************************************

        public readonly static RandomMessenger RandomMessages = new RandomMessenger
        {
            "Just need to climb this hill, 5k's to go... Oh my.. *sweat*",
            "Nice!! Im doing great. I can feel my legs getting better every spin! Woah...",
            "Oh no! I went probably a little bit hard on the first meteres there.",
            "Gonna chase the old lady... *sweat*..  Oh a e-bike thats how... -_-",
            "Working hard..."
        };

        //******************************************************
        //** Properties
        //******************************************************

        public double WorkoutScore { get; private set; } 
        public int WorkoutIntensity { get; private set; }
        
        //******************************************************
        //** Constructor
        //******************************************************
        
        public RestedAndTimeToTrainState(int workoutIntensity)
        {
            WorkoutScore = 0;
            WorkoutIntensity = workoutIntensity;
        }
        
        //******************************************************
        //** Public API
        //******************************************************
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        public override void Enter(Cyclist entity)
        {
            Talk(entity, "Aaaaah I feel rested.. its time go and do my exercise again.");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        public override void Exit(Cyclist entity)
        {
            entity.IncreaseFitness((int)WorkoutScore);
            Talk(entity, $"Oh lord.. That was a good one, time to hit the shower. current fitness = {entity.Fitness}");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        public override void Update(Cyclist entity)
        {
            if (entity.IsFatigued)
            {
                entity.GetFSM().ChangeState(new TiredAndTimeToRestState());
            }
            else
            {
                WorkoutScore += WorkoutIntensity * Math.PI / 100;
                Talk(entity, RandomMessages.GetRandom());
                entity.IncreaseFatigue(1);
            }
        }
    }
}
