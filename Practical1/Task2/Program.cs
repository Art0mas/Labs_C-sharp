using System.Globalization;
using System.Text;

namespace Task2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int[] numbers = GenerateRandomArray(10, 1, 100);
            Console.Write("Масив з 10 випадкових чисел: ");
            PrintArray(numbers); Console.WriteLine();

            Console.WriteLine("Сума усіх значень: " + GetSum(numbers));
            Console.WriteLine("Середнє значення масиву: " + GetAverage(numbers));
            Console.WriteLine("Мінімальне значення масиву: " + GetMin(numbers));
            Console.WriteLine("Масимальне значення масиву: " + GetMax(numbers));
        }

        static public int[] GenerateRandomArray(int size, int min, int max)
        {
            Random rand = new Random();
            int[] array = new int[size];
            for(int i = 0; i < size; i++)
            {
                array[i] = rand.Next(min, max);
            }
            return array;
        }
        static public int GetSum(int[] numbers)
        {
            int sum = 0;
            for(int i=0;i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        static public double GetAverage(int[] numbers)
        {
            double sum = 0;
            int count = 0;
            for(int i=0;i < numbers.Length;i++)
            {
                sum += numbers[i];
                count++;
            }
            return sum/count;
        }

        static public int GetMin(int[] numbers)
        {
            int min = 100;
            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min) min = numbers[i];
            }
            return min;
        }

        static public int GetMax(int[] numbers)
        {
            int max = 1;
            for(int i = 0;i < numbers.Length; i++)
            {
                if (numbers[i] > max) max = numbers[i];
            }
            return max;
        }

        static public void PrintArray(int[] numbers)
        {
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        } 
    }
}