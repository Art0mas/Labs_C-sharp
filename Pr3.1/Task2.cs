using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr3
{
    internal class Task2
    {
        string folderPath = @"D:\Навчання\ДУІКТ\Проекти\2 курс\ПППІ проект";

        public void Example()
        {
            if(Directory.Exists(folderPath))
            {
                string[] files = Directory.GetFiles(folderPath);
                string[] directories = Directory.GetDirectories(folderPath);

                Console.WriteLine("Папка, в якій працюємо: " + folderPath + "\n");

                
                Console.WriteLine("Усі файли:");
                foreach (string file in files)
                {
                    FileInfo fileInfo = new FileInfo(file);
                    float bytes = fileInfo.Length;
                    Console.WriteLine($"{Path.GetFileName(file)} [Створено: {File.GetCreationTime(file)}, Розмір: {bytes/1024:F2} КБ]");
                }

                Console.WriteLine("\nУсі підпапки:");
                foreach (string dir in directories)
                {
                    Console.WriteLine(Path.GetFileName(dir));
                }
            }
            else{
                Console.WriteLine("Директорія не існує");
            }
        }
    }
}
