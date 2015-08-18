using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex18
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter your marks: ");
            int m = Convert.ToInt32(Console.ReadLine());
            String grade;

            if (m >= 80 && m <= 100)
                grade = "A";
            else if (m >= 60 && m <= 79)
                grade = "B";
            else if (m >= 40 && m <= 59)
                grade = "C";
            else if (m >= 0 && m < 40)
                grade = "F";
            else grade = "**Error**";

            Console.WriteLine("Your scored {0} marks which is {1} grade.", m, grade);


        }
    }
}