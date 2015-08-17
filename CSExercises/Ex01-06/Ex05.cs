using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex05
    {
        public static void Main(string[] args)
        {
            double number = 56;
            double sqrtnumber;
            sqrtnumber = Math.Sqrt(number);
            Console.WriteLine("The square root of {0} is {1:.###}.", number, sqrtnumber);
        }
    }
}
