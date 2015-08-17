using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSExercises
{
    public class Ex02
    {
        public static void Main(string[] args)
        {
            int number;
            Console.Write("Please enter a number:");
            number = int.Parse(Console.ReadLine());
            int squarenum = number * number;
            Console.WriteLine("The square of {0} is {1}",number,squarenum);

            //other solution
            //Console.Write("Please enter a number :");
            //String n = Console.ReadLine();
            //int a = Convert.ToInt32(n);
            //double b = Math.Pow (a,2);
            //Console.WriteLine("The result is {0}",b);
        }
    }
}
