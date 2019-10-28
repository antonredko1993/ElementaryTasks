using System;
using System.Collections.Generic;
using System.Text;

namespace ElementaryTasks
{
    class Loops
    {
        public void SumOfEvenValues()
        {
            int sum = 0;
            int count = 0;
            for (int i = 1; i < 99; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                    count++;
                    Console.WriteLine($"Value: {i}");
                }
            }
            Console.WriteLine($"Summ: {sum}");
            Console.WriteLine($"Count: {count}");
        }

        public void PrimeNumber()
        {
            Console.WriteLine("Enter the value");
            int.TryParse(Console.ReadLine(), out int userInput1);

            if (userInput1 <= 1 || userInput1 % 1 != 0)
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

                Console.WriteLine($"{ userInput1} is a prime number");
            }
        }

        public void Square()
        {
            Console.WriteLine("Enter the value");
            int.TryParse(Console.ReadLine(), out int userInput);

            if (userInput <= 1 || userInput % 1 != 0)
            {
                Console.WriteLine($"{userInput} isn't correct value");
            }
            else
            {
                for (int row = 1; row <= userInput; row++)
                {
                    for (int column = 1; column <= userInput; column++)
                    {
                        if (row == 1 || row == userInput)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            if (column == 1 || column == userInput)
                            {
                                Console.Write("*");
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                    }

                    Console.WriteLine();
                }
            }
        }

        public void Chess()
        {
            Console.WriteLine("Enter number of rows");
            int.TryParse(Console.ReadLine(), out int userInput1);

            if (userInput1 <= 1 || userInput1 % 1 != 0)
            {
                Console.WriteLine($"{userInput1} isn't correct value");
            }
            else
            {
                Console.WriteLine("Enter number of columns");
            }

            int.TryParse(Console.ReadLine(), out int userInput2);

            if (userInput2 <= 1 || userInput2 % 1 != 0)
            {
                Console.WriteLine($"{userInput2} isn't correct value");
            }
            else
            {
                for (int row = 1; row <= userInput1; row++)
                {
                    if (row % 2 != 0)
                    {
                        Console.Write(" ");
                    }

                    for (int column = 1; column <= userInput2; column++)
                    {
                        if (column % 2 != 0)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }

        public void Polindrom()
        {





        }
    }
}

        
