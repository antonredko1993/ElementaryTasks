using System;
using System.Collections.Generic;
using System.Text;

namespace ElementaryTasks
{
    class Arrays
    {
        public int FindMinElementOfArray(int[]numbers)
        {
            int minValue = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (minValue > numbers[i])
                {
                    minValue = numbers[i];
                }
            }
            return minValue;
        }

        public int IndexOfMaxValue(int[] numbers)
        {
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
            return index;
        }

        public int CalculateSumOfNonEvenElements(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 !=0)
                {
                    sum += numbers[i];
                }
            }
            return sum;
        }

        public int FindMostCommonValue(int[] numbers)
        {
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
            return mostCommonValue;
        }

        public int[] ArrayReverse(int[] numbers)
        {
            int[] reverseNumbers = new int[numbers.Length];
            for (int i = numbers.Length; i > 0; i--)
            {
                int reverseIndex = numbers.Length - i;
                reverseNumbers[reverseIndex] = numbers[i-1];
            }
            return reverseNumbers;
        }

        public int[] LessThenAverageValue(int[] numbers)
        {
            int sum = 0;
            var lessValues = new List<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            int averageValue = sum / numbers.Length;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < averageValue)
                {
                    lessValues.Add(numbers[i]);
                }
            }
            return lessValues.ToArray();
        }
        public int[] FindElementsWhichHasDivideInArray(int[] numbers)
        {
            var eleventsWhichHasDivide = new List<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[j] % numbers[i] == 0 && numbers[j] != numbers[i])
                    {
                        eleventsWhichHasDivide.Add(numbers[j]);
                    }
                }
            }
            return eleventsWhichHasDivide.ToArray();
        }

        public int[] SwapPartsOfArray(int[] numbers)
        {
            var mirrorNumbers = new List<int>();
            int[] mirrorNumber = new int[numbers.Length];
            for (int i = (numbers.Length / 2); i < numbers.Length; i++)
            {
                int mirrorIndex = i - (numbers.Length/2);
                mirrorNumber[mirrorIndex] = numbers[i];
            }
            for (int i = 0; i < (numbers.Length / 2); i++)
            {
                int mirrorIndex = i+ (numbers.Length / 2);
                mirrorNumber[mirrorIndex] = numbers[i];
            }
            for (int i = 0; i < mirrorNumber.Length; i++)
            {
                mirrorNumbers.Add(mirrorNumber[i]);
            }
            return mirrorNumbers.ToArray();
        }

        public int[] ArrayFilling(int[] array)
        {
            var arrayIndex = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                arrayIndex.Add(i);
            }
            return arrayIndex.ToArray();
        }
    }
}
