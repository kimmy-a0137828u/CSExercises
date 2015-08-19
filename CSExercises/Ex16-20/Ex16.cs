using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex16
    {
        public static void Main(string[] args)
        {            
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Please select your gender: (M = Male or F = Female)");
            string gender = Console.ReadLine();

            if (gender == "m" || gender == "M" )
                gender = "Mr.";
            else if (gender == "F"|| gender == "F")
                gender = "Ms.";
            Console.WriteLine("Good morning {0} {1}", gender, name);                        
                                   
        }
    }
}