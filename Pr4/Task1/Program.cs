using System.Text;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            TaskTracker taskTracker = new TaskTracker();
            taskTracker.Run();
        }
    }
}
