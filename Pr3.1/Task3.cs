using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr3
{
    internal class Task3
    {
        string folderPath = @"D:\Навчання\ДУІКТ\Проекти\2 курс\ПППІ проект";

        public void Example()
        {
            float maxSize = 0;
            string maxFile = string.Empty;
            if(Directory.Exists(folderPath))
            {
                string[] files = Directory.GetFiles(folderPath, "*", SearchOption.AllDirectories);
                foreach(string file in files)
                {
                    FileInfo fileInfo = new FileInfo(file);
                    if(fileInfo.Length > maxSize)
                    {
                        maxSize = fileInfo.Length;
                        maxFile = file;
                    }
                }
                Console.WriteLine("Папка, в якій працюємо: " + folderPath + "\n");
                Console.WriteLine($"- Name: {Path.GetFileName(maxFile)}\n- Size: {maxSize / 1024:F2} КБ\n- Path: {maxFile}");
            }
        }
    }
}
