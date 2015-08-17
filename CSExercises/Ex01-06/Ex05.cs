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
            double number;
            double sqrtnumber;
            Console.Write("Please enter a number:");
            number = Convert.ToDouble(Console.ReadLine());
            sqrtnumber = Math.Sqrt(number);
            Console.WriteLine("The square root of {0} is {1:.000}.", number, sqrtnumber);
        }
    }
}
