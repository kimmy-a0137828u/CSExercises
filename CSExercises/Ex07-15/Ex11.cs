using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex11
    {
        public static void Main(string[] args)
        {
            double min, dist, addfare, total;

            min = 2.40;
            Console.WriteLine("The distance traveled is 3.24KM");
            dist = 3.24;
            addfare = 0.4;
            total = min + dist * addfare;

            Console.WriteLine("The total taxi fare is {0}", total);
        }
    }
}
