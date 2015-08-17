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
            float basic_sal, housingallow, transportallow, totalinc;
            
            Console.WriteLine ("Please enter your salary: ");
            basic_sal =float.Parse(Console.ReadLine());
            housingallow = basic_sal * 10 / 100;
            transportallow = basic_sal * 3 / 100;
            totalinc = basic_sal + housingallow + transportallow;
            Console.WriteLine("Total income of employee is: {0:C}", totalinc);


  
        }
    }
}
