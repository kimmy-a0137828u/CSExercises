using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex10
    {
        public static void Main(string[] args)
        {
            double x1, y1, x2, y2, cal, distance;
            Console.WriteLine("Please enter the value of the following: X1, Y1, X2, Y2 ");
            x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("X1 = {0}", x1);
            y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Y1 = {0}", y1);
            x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("X2 = {0}", x2);
            y2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Y2 = {0}", y2);

            cal = (x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1);

            distance = Math.Sqrt(cal);
            Console.WriteLine("The ditance is {0}", distance);
        }
    }
}
