using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBooth.Utils
{
    /// <summary>
    /// 
    /// </summary>
    public class RandomMessenger : List<string>
    {
        //******************************************************
        //** Fields
        //******************************************************

        private static readonly Random _random = new Random(DateTime.Now.Millisecond);

        //******************************************************
        //** Ctors
        //******************************************************

        public RandomMessenger() {}
        public RandomMessenger(IEnumerable<string> collection) : base(collection) { }
        public RandomMessenger(int capacity) : base(capacity) { }

        /// <summary>
        /// Gets a random message in the list. 
        /// </summary>
        /// <returns></returns>
        public string GetRandom()
        {
            var randomIndex = _random.Next(Count);
            if (randomIndex >= 0 && randomIndex < Count)
            {
                return this[randomIndex];
            }
            return string.Empty;
        }
    }
}
