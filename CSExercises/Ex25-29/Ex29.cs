using System;

namespace CSExercises
{
    public class Ex29
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a integer.");
            int input = Convert.ToInt32(Console.ReadLine());
            int a;
            int b = 0;

            for (a=1; a<=input; a++)
            {
                if(b < input)
                {
                    b = b + a; 
                }
            }
            if ( b == input)
            {
                Console.WriteLine("Perfect Number.");
            }
            else
            {
                Console.WriteLine("Not Perfect Number.");
            }
        }
    }
}
