using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdvancedMath2926;

namespace DLLTest2926
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FACTORIAL CALCULATOR");
            Console.WriteLine("--------------------");

            int input = -1;
            do
            {
                Console.WriteLine("Enter a non-negative integer to calculate its factorial:");
            } while (!int.TryParse(Console.ReadLine(), out input) || input < 0);

            Console.WriteLine(Calculator.Factorial(input));
            Console.ReadKey();
        }
    }
}
