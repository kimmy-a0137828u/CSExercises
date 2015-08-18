using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex17
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name.");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter your gender (M= Male , F= Female).");
            string gender = Console.ReadLine();
            Console.WriteLine("Please enter your age.");
            int age = Convert.ToInt32(Console.ReadLine());

            if ((age >= 40) && (gender == "m" || gender == "M"))
                gender = "Uncle";

            else if ((age >= 40) && (gender == "f" || gender == "F"))
                gender = "Aunty";

            if ((age < 40) && (gender == "m" || gender == "M"))
                gender = "Mr.";
            else if ((age < 40) && (gender == "f" || gender == "F"))
                gender = "Ms.";
                        
            Console.WriteLine("Good morning {0} {1}. ", gender, name);



        }
    }
}