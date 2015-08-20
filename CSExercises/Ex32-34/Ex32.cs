using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSExercises
{
    public class Ex32
    {
        public static void Main(string[] args)
        {
            int[] sales = new int[12];
            int i;
            int max = 0;
            int min = 0;
            double avg = 0;
            for (i =0; i<= 11; i++)
            {
                Console.Write("Enter Sales of the month {0}: ", i);
                sales[i] = Convert.ToInt32(Console.ReadLine());
                max = sales.Max();
                min = sales.Min();
                avg = sales.Average();
            }
            Console.WriteLine("Maximum Sales: {0}\nMinimum Sales: {1}\nAverage Sales:{2}", max, min, avg);
        }
    }
}
