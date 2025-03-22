using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualProgramming_Assignments.A1
{
    class FactorialCalculator
    {
        static void Main(string[] args)
        {
            int num;
            int fact=0;
            Console.WriteLine("Factorial Calculator");
            Console.Write("Enter a Number: ");
            num = Console.Read();

            for(int i=num; i>1; i--)
            {
                fact *= i;
            }

            Console.WriteLine($"Factorial of {num} is {fact}");
        }
    }
}
