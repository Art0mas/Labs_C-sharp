using System.Text;

namespace Task1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Введіть число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(GetMessage(number));
        }

        public static bool IsEven(int number)
        {
            if(number % 2 == 0) return true;
            else return false;
        }
        public static string GetMessage(int number)
        {
            string text1 = "Двері відкриваються!";
            string text2 = "Двері зачинені...";

            if (number % 2 == 0) return text1;
            else return text2;
        }
    }
}