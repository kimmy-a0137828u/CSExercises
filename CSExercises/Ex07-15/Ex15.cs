using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex15
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a three digit integer");
            double x = Convert.ToDouble(Console.ReadLine());
            double a = Math.Floor (x /100);
            double b = Math.Floor((x - 100 * a) / 10);
            double c = x - a * 100 - b * 10;    
                        
            double y = Math.Pow(a, 3) + Math.Pow(b, 3) + Math.Pow(c, 3);

            if (y == x)
            {
                Console.WriteLine("The number {0} is an Armstrong number.", x);
            }
            else
            {
                Console.WriteLine("The number {0} is not an Armstrong number.",x);
            }
        }
    }
}