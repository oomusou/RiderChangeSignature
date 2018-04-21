using System;
using ClassLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            var result = calculator.Calculate(1, 2, 3);
            
            Console.WriteLine("{0}", result);
        }
    }
}