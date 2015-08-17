using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex14
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the side of a.");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the side of b.");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the side of c.");
            double c = double.Parse(Console.ReadLine());

            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            Console.WriteLine("The area of triangle is {0}.", area);



        }
    }
}