using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex08
    {
        public static void Main(string[] args)
        {
            double celsius, fahren;
            Console.WriteLine("Enter the temperature in Celsius (°C) :");
            celsius = int.Parse(Console.ReadLine());
            fahren = (celsius * 1.8) + 32;
            Console.WriteLine("Temperature in Fahrenheit is {0}(°F). ", fahren);
            Console.ReadLine();
        }
    }
}
