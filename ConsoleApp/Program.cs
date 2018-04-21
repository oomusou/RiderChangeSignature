using System;
using ClassLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            var result = calculator.Add(1, 1);
            
            Console.WriteLine("{0}", result);
        }
    }
}