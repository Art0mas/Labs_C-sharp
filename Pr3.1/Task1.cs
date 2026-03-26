using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr3
{
    internal class Task1
    {
        string inputFile = "story.txt";
        string outputFile = "report.txt";

        public void Example()
        {
            if(File.Exists(inputFile) && File.Exists(outputFile))
            {
                string content;
                int countLine, countWord, countChar;
                using(StreamReader sr = new StreamReader(inputFile))
                {
                    content = sr.ReadToEnd();

                    Console.WriteLine(content);
                    Console.WriteLine();

                    countLine = content.Split("\n").Length;
                    Console.WriteLine("Кількість рядків: " + countLine);

                    countWord = content.Split(" ").Length;
                    Console.WriteLine("Кількість слів: " + countWord);

                    countChar = content.Length;
                    Console.WriteLine("Кількість символів: " + countChar);
                }
                using(StreamWriter sw = new StreamWriter(outputFile))
                {
                    sw.WriteLine("Кількість рядків: " + countLine);
                    sw.WriteLine("Кількість слів: " + countWord);
                    sw.WriteLine("Кількість символів: " + countChar);
                }
            }
            else
            {
                Console.WriteLine("Файл не знайдено");
            }
        }
        
    }
}
