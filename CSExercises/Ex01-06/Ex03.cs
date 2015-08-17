using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex03
    {

        public static void Main(string[] args)
        {
            double a, b;  
            Console.Write("Please enter a number:");
            string c = Console.ReadLine();
            a = Convert.ToDouble(c);
            b = Math.Pow (a, 2); 
            Console.WriteLine("The result is {0}", b);
        }
    }
}
