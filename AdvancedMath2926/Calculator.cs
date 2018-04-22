using System;  
using System.Linq;

namespace AdvancedMath2926
{
    public class Calculator
    {
        public static int Factorial(int input)
        {
            return input == 0 ? 1 : Enumerable.Range(1, input).Aggregate((pre, nxt) => pre * nxt);
        }
    }
}
