using System;
using System.Collections.Generic;
using System.Text;

namespace ElementaryTasks
{
    class Arrays
    {
        public void MinElement()
        {
            int[] numbers = { 11, 10, 12, 13, 14, 4, 16, 21, 15, 17 };
            int minValue = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (minValue > numbers[i])
                {
                    minValue = numbers[i];
                }
            }
            Console.WriteLine(minValue);
        }

        public void IndexOfMaxValue()
        {
            int[] numbers = { 11, 10, 12, 13, 14, 4, 16, 21, 15, 17 };
            int maxValue = numbers[0];
            int index = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (maxValue < numbers[i])
                {
                    maxValue = numbers[i];
                    index = i;
                }
            }
            Console.WriteLine(index);
        }

        public void SumOfElements()
        {
            int[] numbers = { 11, 10, 12, 13, 14, 4, 16, 21, 15, 17 };
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 !=0)
                {
                    sum += numbers[i];
                }
            }
            Console.WriteLine(sum);
        }

        public void MostCommonValue()
        {
            int[] numbers = { 11, 10, 12, 13, 14, 13, 16, 13, 15, 4 };
            int longestOccurance = 0;
            int mostCommonValue = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int counter = 0;

                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[j] == numbers[i])
                    {
                        counter++;
                    }
                }

                if (counter > longestOccurance)
                {
                    longestOccurance = counter;
                    mostCommonValue = numbers[i];
                }
            }
            Console.WriteLine(mostCommonValue);
        }

        public void ArrayReverse()
        {
            int[] numbers = { 11, 10, 12, 13, 14, 13, 16, 13, 15, 4 };
            int[] reverseNumbers = new int[numbers.Length];
            for (int i = numbers.Length; i > 0; i--)
            {
                int reverseIndex = numbers.Length - i;
                reverseNumbers[reverseIndex] = numbers[i-1];
            }
            foreach (int reverseIndex in reverseNumbers)
            {
                Console.Write($"{reverseIndex} ");
            }
        }

        public void LessThenAverageValue()
        {
            int[] numbers = { 11, 10, 12, 13, 14, 13, 16, 13, 15, 4 };
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            int averageValue = sum / numbers.Length;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < averageValue)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
        }
        public void Divide()
        {
            int[] numbers = { 11, 10, 12, 13, 14, 13, 16, 13, 15, 4 };
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[j] % numbers[i] == 0 && numbers[j] != numbers[i])
                    {
                        Console.WriteLine(numbers[j]);
                    }
                }
            }
        }

        public void SwapPartsOfArray()
        {
            int[] numbers = { 11, 10, 12, 13, 14, 13, 16, 13, 15, 4, 7 };
            int[] mirrorNumbers = new int[numbers.Length];
            for (int i = (numbers.Length / 2); i < numbers.Length; i++)
            {
                int mirrorIndex = i - (numbers.Length/2);
                mirrorNumbers[mirrorIndex] = numbers[i];
            }
            for (int i = 0; i < (numbers.Length / 2); i++)
            {
                int mirrorIndex = i+ (numbers.Length / 2);
                mirrorNumbers[mirrorIndex] = numbers[i];
            }
            for (int i = 0; i < mirrorNumbers.Length; i++)
            {
                Console.WriteLine(mirrorNumbers[i]);
            }
        }

        public void ArrayFilling()
        {
            int[] array = new int[101];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
                Console.WriteLine(array[i]);
            }
        }
    }
}
