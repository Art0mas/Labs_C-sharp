using System.Text;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            PlayerManager playerManager = new PlayerManager();
            playerManager.Run();
        }
    }
}
