using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex01
    {
        public static void Main(string[] args)
        {
            String name; //Variable for storing string value

            //Displaying message for entering value
            Console.WriteLine("Please enter your name");
            //Accepcting and holding value in name variable
            name = Console.ReadLine();
            //Displaying output
            Console.WriteLine("Good morning {0}", name);

        }
    }
}

