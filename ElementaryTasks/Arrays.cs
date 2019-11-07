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
    }   
}
