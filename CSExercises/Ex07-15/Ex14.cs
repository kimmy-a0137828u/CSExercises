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
            double a, b, c, s, cal, area;
            a = 35;
            b = 24;
            c = 18;
            s = (a + b + c) / 2;
            cal = s*(s-a)*(s-b)*(s-c);
            area = Math.Sqrt(cal);

            Console.WriteLine("The area is {0}", area);

        }
    }
}