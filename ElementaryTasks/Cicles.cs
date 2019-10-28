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
                count ++;
                Console.WriteLine($"Value: {i}");
            }
            Console.WriteLine($"Summ: {sum}");
            Console.WriteLine($"Count: {count}");
        }

        public void PrimeNumber()
        {
            Console.WriteLine("Enter the value");
            double.TryParse(Console.ReadLine(), out double userInput1);

            if (userInput1 <= 1 ^ userInput1 % 1 != 0)
            {
                Console.WriteLine($"{userInput1} isn't a prime number");
            }
            else
            {
                for (int i = 2; i < userInput1; i++)
                {
                    if (userInput1 % i == 0)
                    {
                        Console.WriteLine($"{userInput1} isn't a prime number");
                        return;
                    }
                }

                Console.WriteLine($"{ userInput1} is a prime number" );
            }
        }

















    }
}
