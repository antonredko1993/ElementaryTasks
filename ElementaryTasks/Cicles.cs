using System;
using System.Collections.Generic;
using System.Text;

namespace ElementaryTasks
{
    class Cicles
    {
        public void SumOfEvenValues()
        {
            int sum = 0;
            int count = 0;
            for (int i = 1; i < 99; i++)
            {
                if (i % 2 != 0)
                    continue;

                sum += i;
                count += 1;
                Console.WriteLine($"Value: {i}");
            }
            Console.WriteLine($"Summ: {sum}");
            Console.WriteLine($"Count: {count}");














        }

















    }
}
