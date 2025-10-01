using System.Text;

namespace Task4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            double a, b, c;
            Console.WriteLine("Введіть сторони трикутника: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());

            if (IsValidTriangle(a, b, c)) 
            { 
                Console.WriteLine("Трикутник існує");
                Console.WriteLine("Периметр трикутника: " + GetPerimeter(a, b, c));
                Console.WriteLine("Площа трикутника: " + GetArea(a, b, c));
                Console.WriteLine("Тип трикутника: " + GetTriangleType(a, b, c));
            } 
            else Console.WriteLine("Трикутник не існує");

            
        }

        static public bool IsValidTriangle(double a, double b, double c) 
        {
            if(a<=0 || b<=0 || c<=0) return false;

            if (a + b > c && a + c > b && b + c > a) return true;
            else return false;
        }
        static public double GetPerimeter(double a, double b, double c)
        {
            return a + b + c;
        }
        static public double GetArea(double a, double b, double c)
        {
            double p = GetPerimeter(a, b, c) / 2;
            double v = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return v;
        }
        static public string GetTriangleType(double a, double b, double c)
        {
            double[] sides = { a, b, c };
            Array.Sort(sides); 

            if (a == b && b == c) return "рівносторонній";
            if (a == b || a == c || b == c) return "рівнобедрений";
            if (Math.Abs(sides[0] * sides[0] + sides[1] * sides[1] - sides[2] * sides[2]) < 1e-6)  return "прямокутний";
            else return "довільний";
        }
    }
}