using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex13
    {
        public static void Main(string[] args)
        {
            double min, dist, addfare, total;

            min = 2.40;
            Console.WriteLine("The distance traveled is 3.24KM");
            dist = 3.24;
            addfare = 0.4;
            total = Math.Ceiling (min + dist * addfare); //round upwatds to the nearest
            Console.WriteLine("The total taxi fare is {0:0.00}.", total);
            
        }
    }
}
