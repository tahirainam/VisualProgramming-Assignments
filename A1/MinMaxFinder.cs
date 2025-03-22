using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualProgramming_Assignments.A1
{
    class MinMaxFinder
    {
        static void Main()
        {
            int[] arr = new int[10] ;
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter number for index {i}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            int min = arr[0], max = arr[0];
            int minIndx = 0, maxIndx = 0;
            for (int i = 0; i < 10; i++)
            {
               if (arr[i] > max)
                {
                    max = arr[i];
                    maxIndx = i;
                }
               if (arr[i] < min)
                {
                    min = arr[i];
                    minIndx = i;
                }
            }

            Console.WriteLine($"{max} is the Maximum Number at index {maxIndx}");
            Console.WriteLine($"{min} is the Minimum Number at index {minIndx}");
        }
    }
}
