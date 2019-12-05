using System;
using System.Collections.Generic;
using System.Text;

namespace ElementaryTasks
{
    class Loops
    {
        public SumOfEvenValuesResult SumOfEvenValues()
        {
            var result = new SumOfEvenValuesResult();
            var temp = new List<int>();
            for (int i = 1; i < 99; i++)
            {
                if (i % 2 == 0)
                {
                    result.SumOfEvenValues += i;
                    result.CountOfEvenValues++;
                    temp.Add(i);
                }
            }
            result.EvenValues = temp.ToArray();
            return result;
        }

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

        public char[,] Square(int userInput)
        {
            if (userInput <= 1 || userInput % 1 != 0)
            {
                return new char[0,0];
            }
            else
            {
                char[,] square = new char[userInput,userInput];
                for (int row = 1; row <= userInput; row++)
                {
                    for (int column = 1; column <= userInput; column++)
                    {
                        if (row == 1 || row == userInput)
                        {
                            square[row-1,column-1] ='*';
                        }

                        else
                        {
                            if (column == 1 || column == userInput)
                            {
                                square[row-1, column-1] = '*';
                            }
                            else
                            {
                                square[row-1, column-1] = ' ';
                            }
                        }
                    }
                }
                return square;
            }
        }

        /// <summary>
        /// Use this method to show chess board with set parameters(Height/Width)
        /// </summary>
        /// <param name="userInput1"></param>
        /// <param name="userInput2"></param>
        /// <returns>Chess</returns>
        public char[,] Chess(int userInput1, int userInput2)
        {
            char[,] Chess = new char[userInput1, userInput2];
            if (userInput2 <= 1 || userInput2 % 1 != 0)
            {
                return new char[0, 0];
            }
            else
            {
                for (int row = 1; row <= userInput1; row++)
                {
                    int startIndex = 1;
                    if (row % 2 != 0)
                    {
                        Chess[row - 1, 0] = ' ' ;
                        startIndex = 2;
                    }

                    for (int column = startIndex; column <= userInput2; column++)
                    {
                        if (column % 2 != 0)
                        {
                            Chess[row-1, column-1] = '*';
                        }
                        else
                        {
                            Chess[row-1, column - 1] = ' ';
                        }
                    }
                }
                return Chess;
            }
        }

        public int[] GetPrimeNumbers(int number)                                  
        {
            var temp = new List<int>();
            if (number <= 1)
            {
                return new int[0]; 
            }
            else
            {
                for (int i = 2; i <= number; i++)
                {
                    if (IsPrimeNumber(i))
                    {
                        temp.Add(i);
                    }
                }
            }
            return temp.ToArray();
        }

        public string[] NaturalNumber(int number)
        {
            var square = new List<string>();
            if (number < 1)
            {
                return new string[0];
            }
            else
            {
                for (int i = 1; i < number; i++)
                {
                    if (i * i > number)
                    {
                        square.Add($"Square of number {i}({i * i}) > {number}");
                    }
                    else if (i * i < number)
                    {
                        square.Add($"Square of number {i}({i * i}) < {number}");
                    }
                    else
                    {
                        square.Add($"Square of number {i}({i * i}) = {number}");
                    }
                }
            }
            return square.ToArray();
        }

        public int[] FindDivisorsOfValue(int number)
        {
            var divisors = new List<int>();
            for (int a = 1; a <= number; a++)
            {
                if (number % a == 0)
                {
                    divisors.Add(a);
                }
            }
            return divisors.ToArray();
        }

        public int RootOfNaturalNumber(int number)
        {
            int result = 0;
            if (number < 1)
            {
                result = 0;
            }
            else
            {
                result = (int)(Math.Sqrt(number));
            }
            return result;
        }

        public int FindFactorial(int number)
        {
            int f = 1;
            if (number < 1)
            {
                f = 0;
            }
            else
            {
                for (int i = number; i > 1; i--)
                {
                    f = f * i;
                }
            }
            return f;
        }

        public double FindAverageValue(int number)
        {
            double result;
            if (number < 1)
            {
                result = 0;
            }
            else
            {
                int sum = 0;
                int amount = 0;
                for (int i = 1; i <= number; i++)
                {
                    if (i == 1 || !IsPrimeNumber(i))
                    {
                        sum += i;
                        amount++;
                    }
                }
                result = (double)sum / amount;
            }
            return result;
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

        public int CalculateSumOfNumbersOfValue(int number)
        {
            int result;
            if (number < 1)
            {
                result = 0;
            }
            else
            {
                int sum = 0;
                while (number > 0)
                {
                    sum += number % 10;
                    number /= 10;
                }
                result = sum;
            }
            return result;
        }

        public int GetMirrorNumber(int number)
        {
            int result;
            if (number < 1)
            {
                result = 0;
            }
            else
            {
                result = 0;
                while (number > 0)
                {
                    result *= 10;
                    result += number % 10;
                    number /= 10;
                }
            }
            return result;
        }
    }   

}

        
