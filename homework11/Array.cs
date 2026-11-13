using System;
using System.Linq;

namespace homeworks
{
    
    public class Array : IOutput2, ICalc2
    {
        private int[] numbers;

        
        public Array(int[] numbers)
        {
            this.numbers = numbers;
        }

       
        public void ShowEven()
        {
            Console.WriteLine("ლუწი რიცხვები მასივიდან:");
            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                {
                    Console.Write(num + " ");
                }
            }
            Console.WriteLine();
        }

        public void ShowOdd()
        {
            Console.WriteLine("კენტი რიცხვები მასივიდან:");
            foreach (var num in numbers)
            {
                if (num % 2 != 0)
                {
                    Console.Write(num + " ");
                }
            }
            Console.WriteLine();
        }

        
        public int CountDistinct()
        {
            
            return numbers.Distinct().Count();
        }

        public int EqualToValue(int valueToCompare)
        {
            
            int count = 0;
            foreach (var num in numbers)
            {
                if (num == valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }
    }
}