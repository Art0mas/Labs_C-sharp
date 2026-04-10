using System.Text;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            AnimalManager animalManager = new AnimalManager();
            animalManager.Run();
        }
    }
}
