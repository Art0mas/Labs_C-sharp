using System.Text;

namespace Task5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int[][] studentGroups = new int[4][];
            studentGroups[0] = new int[] { 90, 85, 70, 75, 95, 60 }; 
            studentGroups[1] = new int[] { 75, 50, 80, 65, 75, 70, 85, 70 }; 
            studentGroups[2] = new int[] { 98, 95, 100, 91, 99, 93 }; 
            studentGroups[3] = new int[] { 40, 50, 60, 70, 80, 90, 100 }; 

            Console.WriteLine("Статистика по групах: ");
            PrintGroupStatistics(studentGroups);
        }

        static public double GetAverage(int[] marks) 
        {
            double sum = 0;
            for(int i = 0; i < marks.Length; i++)
            {
                sum += marks[i];
            }
            return sum / marks.Length;
        }
        static public int GetMin(int[] marks)
        {
            int min = marks[0];
            for (int i = 1; i < marks.Length; i++)
            {
                if (marks[i] < min)  min = marks[i];
            }
            return min;
        }
        static public int GetMax(int[] marks)
        {
            int max = marks[0];
            for (int i = 1; i < marks.Length; i++)
            {
                if (marks[i] > max) max = marks[i];
            }
            return max;
        }
        static public void PrintGroupStatistics(int[][] groups)
        {
            for (int i = 0; i < groups.Length; i++)
            {
                int[] currentGroupMarks = groups[i];

                if (currentGroupMarks == null || currentGroupMarks.Length == 0)
                {
                    Console.WriteLine($"Група {i + 1}: порожня. Статистика недоступна.");
                    continue;
                }

                double average = GetAverage(currentGroupMarks);
                int min = GetMin(currentGroupMarks);
                int max = GetMax(currentGroupMarks);

                Console.WriteLine($"Група {i + 1}: Середній = {average:F0}, Мінімальний = {min}, Максимальний = {max}");
            }
        }

    }
}