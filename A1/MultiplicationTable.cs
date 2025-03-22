using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualProgramming_Assignments.A1
{
    class MultiplicationTable
    {
        static void Main()
        {
            int num;
            Console.WriteLine("Multiplication Table");
            Console.Write("Enter a Number: ");
            num = int.Parse(Console.ReadLine());
            PrintTable(num);
        }
        static void PrintTable(int num)
        {
            for (int i = 1; i <= 9; i++)
            {
                int a = num * i;
                Console.WriteLine($"{num} * {i} = {a}");
            }
        }
    }
}
