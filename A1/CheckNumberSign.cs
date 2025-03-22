using System;

namespace VisualProgramming_Assignments.A1
{
    class CheckNumberSign
    {
        static void Main (string[] args)
        {
            int num;
            Console.WriteLine("Check Number Sign");
            Console.Write("Enter a Number: ");
            num = Console.Read();

            if(num == 0)
            {
                Console.WriteLine("A Zero");
            }
            else if(num > 0)
            {
                Console.WriteLine("A Positive Number");
            }
            else
            {
                Console.WriteLine("A Negative Number");
            }
        }
    }
}