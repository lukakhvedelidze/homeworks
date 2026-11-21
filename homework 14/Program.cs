using System;
using System.Collections.Generic;

namespace homeworks
{
    public static class CollectionHelper
    {
        public static List<T> Where<T>(T[] array, Func<T, bool> predicate)
        {
            List<T> result = new List<T>();
            foreach (var item in array)
            {
                if (predicate(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        public static T FirstOrDefault<T>(T[] array, Func<T, bool> predicate)
        {
            foreach (var item in array)
            {
                if (predicate(item))
                {
                    return item;
                }
            }
            return default(T);
        }

        public static bool Any<T>(T[] array, Func<T, bool> predicate)
        {
            foreach (var item in array)
            {
                if (predicate(item))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool All<T>(T[] array, Func<T, bool> predicate)
        {
            foreach (var item in array)
            {
                if (!predicate(item))
                {
                    return false;
                }
            }
            return true;
        }

        public static int Count<T>(T[] array, Func<T, bool> predicate = null)
        {
            int count = 0;
            foreach (var item in array)
            {
                if (predicate == null || predicate(item))
                {
                    count++;
                }
            }
            return count;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var evenNumbers = CollectionHelper.Where(numbers, n => n % 2 == 0);
            int firstEven = CollectionHelper.FirstOrDefault(numbers, n => n > 5);
            bool hasNegative = CollectionHelper.Any(numbers, n => n < 0);
            bool allPositive = CollectionHelper.All(numbers, n => n > 0);
            int totalCount = CollectionHelper.Count(numbers);
            int evenCount = CollectionHelper.Count(numbers, n => n % 2 == 0);

            Console.WriteLine($"Even numbers count: {evenCount}");
            Console.WriteLine($"First number greater than 5: {firstEven}");
            Console.WriteLine($"Has negative: {hasNegative}");
            Console.WriteLine($"All positive: {allPositive}");
            Console.WriteLine($"Total count: {totalCount}");
        }
    }
}