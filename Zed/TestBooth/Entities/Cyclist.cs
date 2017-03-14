using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zed.StateMachine.Core;

namespace TestBooth.Entities
{
    public class Cyclist : StateGameObject<Cyclist>
    {

        //******************************************************
        //** Static fields
        //******************************************************

        private const int SleepQuality = 1;

        //******************************************************
        //** Properties
        //******************************************************

        /// <summary>
        /// A cyclist's current stamina score. 
        /// </summary>
        public int Stamina { get; private set; }

        /// <summary>
        /// A cyclist's current fatigue score. 
        /// </summary>
        public int Fatigue { get; private set; }

        /// <summary>
        /// A cyclist's current fitness level.
        /// </summary>
        public int Fitness { get; private set; }

        /// <summary>
        /// Functional Threshold Power.
        /// </summary>
        public double FTP => (Stamina * Fitness) / Math.PI; // Cus heeeey, why not.. 

        /// <summary>
        /// Indicates if the cyclist is fatiged and cannot train more. 
        /// </summary>
        public bool IsFatigued => Fatigue >= Stamina;

        /// <summary>
        /// 
        /// </summary>
        public bool IsRested => Fatigue == 0;

        //******************************************************
        //** Ctor
        //******************************************************

        public Cyclist(IStateMachine<Cyclist> fsm)
            : base(fsm)
        {
            fsm.SetOwner(this);
            Stamina = 10;
            Fitness = 10;
            Fatigue = 0;
        }
        
        //******************************************************
        //** Public API
        //******************************************************

        /// <summary>
        /// Adds the intensity score to the fatigue...
        /// TODO: Do something more fancy here. 
        /// </summary>
        /// <param name="intensity"></param>
        public void IncreaseFatigue(int intensity)
        {
            Fatigue += intensity;
        }

        /// <summary>
        /// 
        /// </summary>
        public void DecreaseFatigue()
        {
            Fatigue = Math.Max(0, Fatigue - SleepQuality);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="workoutScore"></param>
        public void IncreaseFitness(int workoutScore)
        {
            var cachedColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{workoutScore}, {Stamina}");
            Console.WriteLine(workoutScore * Stamina * 0.5);
            Console.ForegroundColor = cachedColor;

            Fitness += (int)(workoutScore * Stamina * 0.5);
        }
    }
}
