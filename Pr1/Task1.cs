using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr1
{
    internal class Task1
    {

        public delegate double MathOperation(double x, double y);
        private double Add(double x, double y)
        {
            return x + y;
        } 

        private double Substract(double x, double y)
        {
            return x - y;
        }

        private double Multiply(double x, double y)
        {
            return x * y;
        }

        private double Divide(double x, double y)
        {
            return x / y;
        }

        public void Example()
        {
            MathOperation operation = Add;
            double result = operation(0.5, 1.9);
            Console.WriteLine($"Result: {result}");

            operation = Substract;
            result = operation(0.5, 1.9);
            Console.WriteLine($"Result: {result}");

            operation = Multiply;
            result = operation(0.5, 1.9);
            Console.WriteLine($"Result: {result}");

            operation = Divide;
            result = operation(0.5, 1.9);
            Console.WriteLine($"Result: {result}");

        }
    }
}
