using System;

namespace CSExercises
{
    public class Ex20
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("The price of TV is $900");
            Console.WriteLine("The price of DVD is $500");
            Console.WriteLine("The price of MP3 is $700");

            double tv, dvd, mp3, o1, o2, o3, total1, total2;
            tv = 900;
            dvd = 500;
            mp3 = 700;
            
            Console.Write("Enter quantity for TV: ");
            o1 = Convert.ToInt32(Console.ReadLine()) * tv;
            Console.Write("Enter quantity for DVD: ");
            o2 = Convert.ToInt32(Console.ReadLine()) * dvd;
            Console.Write("Enter quantity for MP3: ");
            o3 = Convert.ToInt32(Console.ReadLine()) * mp3;

            total1 = o1 + o2;
                        
            if (total1 >= 5000)
                total1 = (total1 - (total1* 0.1));
            else if (total1 >= 10000)
                total1 = (total1 - (total1 * 0.15));
            else { }

            total2 = total1 + o3;

            Console.WriteLine("Total price for this order is {0:C}", total2);
        }
    }
}