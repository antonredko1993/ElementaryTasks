using System;
using System.Collections.Generic;
using System.Text;

namespace ElementaryTasks
{
    class Loops
    {
        //public void SumOfEvenValues(out int a,  int sum, out int count)
        //{
        //    for (int i = 1; i < 99; i++)
        //    {
        //        if (i % 2 == 0)
        //        {
        //            sum += i;
        //            count++;
        //            int a = i;
        //            Console.WriteLine($"Value: {i}");
        //        }
        //    }
        //    Console.WriteLine($"Summ: {sum}");
        //    Console.WriteLine($"Count: {count}");
        //}

        public bool PrimeNumber(int userInput1)
        {
            if (userInput1 <= 1 || userInput1 % 1 != 0)
            {
                return false;
            }
            else
            {
                for (int i = 2; i < userInput1; i++)
                {
                    if (userInput1 % i == 0)
                    {
                        return false;
                    }
                }
                return true;
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

        public void PrintPrimeNumbers()                                  
        {
            Console.WriteLine("Enter the value");
            int.TryParse(Console.ReadLine(), out int userInput);

            if (userInput <= 1)
            {
                Console.WriteLine($"{userInput} isn't correct value");
            }
            else
            {
                for (int i = 2; i <= userInput; i++)
                {
                    if (IsPrimeNumber(i))
                    {
                        Console.WriteLine($"{i}");
                    }
                }

            }
        }

        public void NaturalNumber()
        {
            Console.WriteLine("Enter the value");
            int.TryParse(Console.ReadLine(), out int userInput);

            if (userInput < 1)
            {
                Console.WriteLine($"{userInput} isn't correct value");
            }
            else
            {
                for (int i = 1; i < userInput; i++)
                {
                    if (i * i > userInput)
                    {
                        Console.Write($"Square of number {i}({i * i}) > {userInput}");
                    }
                    else if (i * i < userInput)
                    {
                        Console.Write($"Square of number {i}({i * i}) < {userInput}");
                    }
                    else
                    {
                        Console.Write($"Square of number {i}({i * i}) = {userInput}");
                    }
                    Console.WriteLine();
                }
            }
        }

        public void Divisors()
        {
            Console.WriteLine("Enter the value");
            int.TryParse(Console.ReadLine(), out int userInput);
            for (int a = 1; a <= userInput; a++)
            {
                if (userInput % a == 0)
                {
                    Console.WriteLine(a);
                }
            }
        }

        public void RootOfNaturalNumber()
        {
            Console.WriteLine("Enter the value");
            int.TryParse(Console.ReadLine(), out int userInput);

            if (userInput < 1)
            {
                Console.WriteLine($"{userInput} isn't correct value");
            }
            else
            {
                Console.WriteLine(Math.Sqrt(userInput));
            }
        }

        public void Factorial()
        {
            Console.WriteLine("Enter the value");
            int.TryParse(Console.ReadLine(), out int userInput);

            if (userInput < 1)
            {
                Console.WriteLine($"{userInput} isn't correct value");
            }
            else
            {
                int F = 1;
                for (int i = userInput; i > 1; i--)
                {
                    F = F * i;
                }
                Console.WriteLine($"Factorial: {F}");
            }
        }

        public void AverageValue()
        {
            Console.WriteLine("Enter the value");
            int.TryParse(Console.ReadLine(), out int userInput);

            if (userInput < 1)
            {
                Console.WriteLine($"{userInput} isn't correct value");
            }
            else
            {
                int sum = 0;
                int number = 0;
                for (int i = 1; i <= userInput; i++)
                {
                    if (i == 1 || !IsPrimeNumber(i))
                    {
                        sum += i;
                        number++;
                    }
                }
                double result = (double)sum / number;
                Console.WriteLine(result);
            }
        }
        static bool IsPrimeNumber(int num)                    
        {
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public void CalculateSum()
        {
            Console.WriteLine("Enter the value");
            int.TryParse(Console.ReadLine(), out int userInput);

            if (userInput < 1)
            {
                Console.WriteLine($"{userInput} isn't correct value");
            }
            else
            {
                int sum = 0;
                while (userInput > 0)
                {
                    sum += userInput % 10;
                    userInput /= 10;
                }
                Console.WriteLine(sum);
            }
        }

        public void MirrorNumber()
        {
            Console.WriteLine("Enter the value");
            int.TryParse(Console.ReadLine(), out int userInput);

            if (userInput < 1)
            {
                Console.WriteLine($"{userInput} isn't correct value");
            }
            else
            {
                int result = 0;
                while (userInput > 0)
                {
                    result *= 10;
                    result += userInput % 10;
                    userInput /= 10;
                }
                Console.WriteLine(result);
            }
        }
    }   

}

        
