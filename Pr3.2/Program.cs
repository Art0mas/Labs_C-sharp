namespace Pr3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string folderPath = args[0];

            if (Directory.Exists(folderPath))
            {
                string[] files = Directory.GetFiles(folderPath, "*", SearchOption.AllDirectories);
                int countFolders = Directory.GetDirectories(folderPath, "*", SearchOption.AllDirectories).Length;
                int countFiles = Directory.GetFiles(folderPath, "*", SearchOption.AllDirectories).Length;
                float totalSize = 0;
                float maxSize = 0;
                string maxSizeFile = string.Empty;

                foreach(string file in files)
                {
                    FileInfo fileInfo = new FileInfo(file);
                    totalSize += fileInfo.Length;
                    if(fileInfo.Length > maxSize)
                    {
                        maxSize = fileInfo.Length;
                        maxSizeFile = file;
                    }
                }
                Console.WriteLine($"The working folder: {folderPath}");
                Console.WriteLine($"Folders: {countFolders}\nFiles: {countFiles}\n" +
                    $"Total size: {totalSize/1024/1024/1024:F2} GB\nLargest file: " +
                    $"{Path.GetFileName(maxSizeFile)}({maxSize/1024/1024/1024:F2} GB)");
            }
        }
    }
}
