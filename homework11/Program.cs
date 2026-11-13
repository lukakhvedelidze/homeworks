using System;

namespace homeworks
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] testArray = { 5, 2, 5, 8, 2, 9, 5, 1, 4, 6 };

            
            Array myArray = new Array(testArray);

            Console.WriteLine("=== IOutput2 ტესტირება ===");
            myArray.ShowEven();
            myArray.ShowOdd();

            Console.WriteLine("\n=== ICalc2 ტესტირება ===");
            Console.WriteLine($"უნიკალური მნიშვნელობების რაოდენობა: {myArray.CountDistinct()}");

            int target = 5;
            Console.WriteLine($"რიცხვი {target} მასივში გვხვდება {myArray.EqualToValue(target)}-ჯერ.");
        }
    }
}