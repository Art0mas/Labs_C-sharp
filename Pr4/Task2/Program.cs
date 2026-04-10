using System.Text;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            StudentManager studentManager = new StudentManager();
            studentManager.Run();
        }
    }
}
