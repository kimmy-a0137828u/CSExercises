using System;
namespace CSExercises
{
    public class Ex28
    {
        public static void Main(string[] args)
        {
            bool isPrime = true;
            int a;
            Console.Write("Please enter a integer which you want to find prime number: ");
            int input = Convert.ToInt32(Console.ReadLine());    

            for (a = 2; a<= input/2; a++)//prime number start from 2
            {
                    if (input % a == 0) 
                    {
                        isPrime = false;
                        break;
                    }
                }
                        
            if (isPrime == true)
            {
                Console.WriteLine("Prime");  
            }
            else
                 Console.WriteLine("Not prime");
            }
            
        }
    }
