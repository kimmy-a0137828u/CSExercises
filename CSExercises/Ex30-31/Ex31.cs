using System;
namespace CSExercises
{
    public class Ex31
    {
        public static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Print perfect number: ");
            for (n= 1; n<1001; n++)
            {
                int i;
                int f = 0;
                for (i = 1; i <= n; i++)
                {
                    if(f<n)
                    {
                        f = f + i;
                    }                    
                }
                if (f == n)
                    Console.WriteLine(n);
            }
         
        }
      }
  }