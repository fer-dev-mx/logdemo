using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogDemo.Calculator
{
    public class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        public double Subtract(double x, double y)
        {
            return x - y;
        }
        public double Multiply(double x, double y)
        {
            return x * y;
        }
        public int Division(int x, int y)
        {
            return x / y;
        }
        public double Division(double x, double y)
        {
            return x / y;
        }
        public double squareRoot(double x)
        {
            return Math.Sqrt(x);
        }
    }
}
