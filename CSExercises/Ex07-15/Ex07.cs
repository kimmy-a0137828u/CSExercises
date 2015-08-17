using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex07
    {
        public static void Main(string[] args)
        {            
            double basic_sal, housingallow, transportallow, totalinc;
            
            Console.Write ("Please enter your salary: ");
            basic_sal = Convert.ToDouble (Console.ReadLine());
            housingallow = basic_sal * 10 / 100;
            transportallow = basic_sal * 3 / 100;
            totalinc = basic_sal + housingallow + transportallow;
            Console.WriteLine("Total income of employee is " + totalinc.ToString ("c"));


  
        }
    }
}
