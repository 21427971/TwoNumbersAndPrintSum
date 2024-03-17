using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoNumbersAndPrintSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //A C# program that takes two numbers as input from the user and prints their sum.
            
            Console.WriteLine("Enter a first Number");
            int Number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a second Number");
            int Number2 = int.Parse(Console.ReadLine());
            int Sum = 0;
            Sum = Number1 + Number2;

            Console.WriteLine($"The sum of {Number1} + {Number2} is {Sum} ");
        }
    }
}
