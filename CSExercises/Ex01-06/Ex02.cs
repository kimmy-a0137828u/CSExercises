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
        }
    }
}
