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
            double x1, y1, x2, y2;
            Console.WriteLine("Please enter the value for: X1");
            x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("X1 = {0}", x1);
            Console.WriteLine("Please enter the value for: Y1");
            y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Y1 = {0}", y1);
            Console.WriteLine("Please enter the value for: X2");
            x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("X2 = {0}", x2);
            Console.WriteLine("Please enter the value for: Y2");
            y2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Y2 = {0}", y2);

            double x = Math.Pow(x2 - x1, 2);
            double y = Math.Pow(y2 - y1, 2);

            double distance = Math.Sqrt(x+y);
            Console.WriteLine("The ditance between the point is  {0}", distance);
        }
    }
}
