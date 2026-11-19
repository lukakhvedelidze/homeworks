using System;

namespace homeworks
{
    public static class ArrayHelper
    {
        
        public static void PrintReverse<T>(T[] array)
        {
            Console.WriteLine("massive reversed:");
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        
        public static T GetFirstElement<T>(T[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException("massive is empty.");
            }
            return array[0];
        }

        
        public static T GetLastElement<T>(T[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException("massive is empty.");
            }
            return array[array.Length - 1];
        }

        
        public static bool ContainsElement<T>(T[] array, T value)
        {
            foreach (var item in array)
            {
                
                if (item.Equals(value))
                {
                    return true;
                }
            }
            return false;
        }

        
        public static int CountElements<T>(T[] array)
        {
            int count = 0;
            foreach (var item in array)
            {
                count++;
            }
            return count;
        }

        
        public static int FindIndex<T>(T[] array, T value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(value))
                {
                    return i; 
                }
            }
            return -1;
        }

        
        public static void Swap<T>(T[] array, int index1, int index2)
        {
            if (index1 >= 0 && index1 < array.Length && index2 >= 0 && index2 < array.Length)
            {
                T temp = array[index1];
                array[index1] = array[index2];
                array[index2] = temp;
            }
            else
            {
                Console.WriteLine("index incorrect!");
            }
        }
    }
}
