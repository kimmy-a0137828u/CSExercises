using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex19
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter the travelled distance: ");
            double dst = Convert.ToDouble(Console.ReadLine());
            dst = Math.Ceiling (dst * 10 )/10;            
            Console.WriteLine("The distance is rounded to {0:.00}km .", dst);

            double dst1 = Convert.ToDouble(dst);
                dst1 = 85 * 0.04;
            double dst2 =Convert.ToDouble(dst); 
                dst2 = (dst * 10 - 90) * 0.05;
            double total = Math.Round ((2.40 + dst1 + dst2),1);
            Console.WriteLine("The cost would be {0:C}", total);
            
            
            
        }
    }
}  