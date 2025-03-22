using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualProgramming_Assignments.A1
{
    class PrimeChecker
    {
        static void Main()
        {
            int num;
            Console.WriteLine("Prime or Composite");
            Console.Write("Enter a Number: ");
            num = int.Parse(Console.ReadLine());

            if (num < 2)
            {
                Console.WriteLine($"{num} Not Prime");
            }
            else
            {
                bool isPrime = true;
                for (int i = 2; i*i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine($"{num} is Prime");
                }
                else
                {
                    Console.WriteLine($"{num} is Composite");
                }
            }
        }
    }
}
