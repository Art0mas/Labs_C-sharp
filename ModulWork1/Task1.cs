using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulWork1
{
    internal class Task1
    {
        string inputFile = "textPD24.txt";
        string outputFile = "resultPD24.txt";

        public delegate string TextOperation(string text);

        private string LineToUpper(string text)
        {
            return $"Текст у великому регістрі:\n{text.ToUpper()}";
        }
        private string CountOfSymbols(string text)
        {
            return $"Кількість символів: {text.Length}";
        }

        private string CountOfWords(string text)
        {
            return $"Кількість слів: {text.Split(" ").Length}";
        }

        public void ProcessFile(string inputFile, string outputFile, TextOperation operation)
        {
            if(File.Exists(inputFile))
            {
                string text, result;
                using(StreamReader sr = new StreamReader(inputFile))
                {
                    text = sr.ReadToEnd();
                    
                }

                result = operation(text);
                using (StreamWriter sw = new StreamWriter(outputFile, true))
                {
                    sw.WriteLine(result);
                }
            }
        }

        public void Example()
        {
            File.WriteAllText(outputFile, string.Empty);
            ProcessFile(inputFile, outputFile, CountOfWords);
            ProcessFile(inputFile, outputFile, CountOfSymbols);
            ProcessFile(inputFile, outputFile, LineToUpper);
        }
    }
}
