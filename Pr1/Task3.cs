using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr1
{
    internal class Task3
    {
        public delegate bool FilterPredicate(int x);

        private void FilterArray(int[] numbers, FilterPredicate predicate)
        {
            foreach (int number in numbers)
            {
                if (predicate(number))
                {
                    Console.Write(number + " ");
                }
            }
            Console.WriteLine();
        }
        private static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        private static bool IsGreaterThanFive(int number)
        {
            return number > 5;
        }

        public void Example()
        {
            int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            FilterPredicate filter = IsEven;
            FilterArray(numbers, filter);

            filter = IsGreaterThanFive;
            FilterArray(numbers, filter);

            filter = x => x % 2 != 0;
            FilterArray(numbers, filter);
        }
    }
}
