using System.Text;

namespace Task3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Введіть Ваш вік: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(ClassifyAge(age));
        }

        static public string ClassifyAge(int age)
        {
            if(age < 0 || age > 120) return "Нереальний вік";

            if(age < 12) return "Ви дитина";
            else if(age < 18) return "Підліток";
            else if(age < 60) return "Дорослий";
            else return "Пенсіонер";
        }
    }
}