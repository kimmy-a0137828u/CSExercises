using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex06
    {
        public static void Main(string[] args)
        {
            
            int number;
            double sqrtnumber;
            Console.WriteLine("Input a number to squre root:");
            number = Convert.ToInt32(Console.ReadLine()); //Convert the user input to INT32 from a double
            sqrtnumber = Math.Sqrt(number);
            Console.WriteLine("The square root of {0} is {1}.", number, sqrtnumber);

        }
    }
}
