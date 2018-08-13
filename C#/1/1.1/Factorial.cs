using System;

namespace _1._1
{
    public class Factorial
    {
        public static int calculateFactorial(int n)
        {
            var initFactorialValue = 1;
            for (var index = 1; index <= n; index++)
            {
                initFactorialValue *= index;
            }
            return initFactorialValue;
        }

        public static void Main(string[] arg)
        {
            Console.WriteLine("Factorial from 5! equals {0}", calculateFactorial(5));
            Console.ReadKey();
        }
    }
}