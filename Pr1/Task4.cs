using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Pr1.Task1;

namespace Pr1
{
    internal class Task4
    {
        public Func<double, double, double>? MathOperation;
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

        private void FindNameByLetter(char letter)
        {
            List<string> students = new List<string>
            {
                "Анна", "Богдан", "Олена", "Вiктор", "Олександр", "Марiя", "Олег", "Iван"
            };

            Console.WriteLine("Список усiх студентiв:");
            Console.WriteLine(string.Join(", ", students));

            char searchLetter = letter;

            List<string> filteredStudents = students.FindAll(name => name.StartsWith(searchLetter));

            Console.WriteLine($"\nСтуденти, iмена яких починаються на '{searchLetter}':");

            if (filteredStudents.Count > 0)
            {
                foreach (string student in filteredStudents)
                {
                    Console.WriteLine($"- {student}");
                }
            }
            else
            {
                Console.WriteLine("Студентiв з такою лiтерою не знайдено.");
            }
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

            FindNameByLetter('О');

        }
    }
}
