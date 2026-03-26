using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr3
{
    internal class Task4
    {
        private string cacheFolder1 = @"C:\Users\Admin\AppData\Roaming\discord\Cache";
        private string cacheFolder2 = @"C:\Users\Admin\AppData\Roaming\discord\Code Cache";
        private string cacheFolder3 = @"C:\Users\Admin\AppData\Roaming\discord\GPUCache";
        public void Example()
        {
            if (Directory.Exists(cacheFolder1) && Directory.Exists(cacheFolder2) && Directory.Exists(cacheFolder3))
            {
                string[] files1 = Directory.GetFiles(cacheFolder1, "*", SearchOption.AllDirectories);
                string[] files2 = Directory.GetFiles(cacheFolder2, "*", SearchOption.AllDirectories);
                string[] files3 = Directory.GetFiles(cacheFolder3, "*", SearchOption.AllDirectories);

                List<string> files = new List<string>();
                files.AddRange(files1);
                files.AddRange(files2);
                files.AddRange(files3);

                int Count = 0;
                float size = 0;

                foreach (string file in files)
                {
                    FileInfo fileInfo = new FileInfo(file);
                    size += fileInfo.Length;
                    fileInfo.Delete();
                    if (!fileInfo.Exists)
                    {
                        Count++;
                    }
                }
                Console.WriteLine($"Звіт очищення кешу:\nВидалено файлів: {Count}\nСумарний розмір: " +
                    $"{size / 1024 / 1024:F2} МБ\n");
            }
        }
    }
}
