using System;

namespace Week6GitHubActivity
{
    class Program
    {
               static bool IsPrime(int num)
              {
             if (num <= 1) return false;
             for (int i = 2; i <= Math.Sqrt(num); i++)
             {
                 if (num % i == 0) return false;
              }
              return true;
             }

            static bool IsComposite(int num)
            {
               return num > 1 && !IsPrime(num);
             }
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine(number + " is Even.");
            }
            else
            {
                Console.WriteLine(number + " is Odd.");
            }
            if (IsPrime(number))
          {
                 Console.WriteLine(number + " is a Prime number.");
          }
         else if (IsComposite(number))
           {
                 Console.WriteLine(number + " is a Composite number.");
          }
           else
          {
                 Console.WriteLine(number + " is neither Prime nor Composite.");
            }

     

        }
    }
}
