using System;
using LogDemo.Calculator;

namespace LogDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator.Calculator();
            Console.WriteLine($"5+3 = {calculator.Add(5, 3)}");
        }
    }
}
