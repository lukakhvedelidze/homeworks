using System;

namespace homeworks
{
    class Program
    {
        static void Main(string[] args)
        {
            // ვქმნით სატესტო მასივს
            string[] names = { "ლუკა", "ნინო", "გიორგი", "ანა", "დავითი" };

            Console.WriteLine("=== 1. PrintReverse ტესტირება ===");
            ArrayHelper.PrintReverse(names);

            Console.WriteLine("\n=== 2. GetFirstElement & GetLastElement ===");
            Console.WriteLine($"პირველი ელემენტი: {ArrayHelper.GetFirstElement(names)}");
            Console.WriteLine($"ბოლო ელემენტი: {ArrayHelper.GetLastElement(names)}");

            Console.WriteLine("\n=== 3. ContainsElement ტესტირება ===");
            bool hasNino = ArrayHelper.ContainsElement(names, "ნინო");
            bool hasGiorgi = ArrayHelper.ContainsElement(names, "გიგა");
            Console.WriteLine($"შეიცავს თუ არა 'ნინო'-ს? {hasNino}");
            Console.WriteLine($"შეიცავს თუ არა 'გიგა'-ს? {hasGiorgi}");

            Console.WriteLine("\n=== 4. CountElements (Length-ის გარეშე) ===");
            int totalCount = ArrayHelper.CountElements(names);
            Console.WriteLine($"ელემენტების რაოდენობა: {totalCount}");

            Console.WriteLine("\n=== 5. FindIndex ტესტირება ===");
            int index = ArrayHelper.FindIndex(names, "ანა");
            int notFoundIndex = ArrayHelper.FindIndex(names, "საბა");
            Console.WriteLine($"'ანა'-ს ინდექსია: {index}");
            Console.WriteLine($"'საბა'-ს ინდექსი (არარსებული): {notFoundIndex}");

            Console.WriteLine("\n=== 6. Swap ტესტირება ===");
            Console.WriteLine($"გაცვლამდე (ინდექსი 0: {names[0]}, ინდექსი 3: {names[3]})");

            
            ArrayHelper.Swap(names, 0, 3);

            Console.WriteLine($"გაცვლის შემდეგ (ინდექსი 0: {names[0]}, ინდექსი 3: {names[3]})");
        }
    }
}
