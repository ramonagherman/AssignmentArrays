using System;
using System.Linq;

namespace AssignmentArrays
{
    class Program
    {
        static int Main(string[] args)
        {
            int a = 1, b = 1, fib;
            int n = ReadNumber("Introduceti numarul de elemente: ");

            Console.Write($"Sirul Fibonacci este:");                           
            Console.WriteLine();            

            Console.Write($" {a}, {b} ,");

            for (int i = 3; i <= n; i++)
            {
                fib = a + b;
                a = b;
                b = fib;
                Console.Write($"{fib}, ");
            }

            return 0;
        }       

        static int ReadNumber(string label)
        {
            Console.Write(label);
            string value = Console.ReadLine();
            int valueAsNumber = Convert.ToInt32(value);
            return valueAsNumber;
        }
    }

}
