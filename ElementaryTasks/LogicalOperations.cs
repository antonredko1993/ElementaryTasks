using System;
using System.Collections.Generic;
using System.Text;

namespace ElementaryTasks
{
    class LogicalOperations
    {
        public void FindMax()                    //1)	Найти наибольшее значение из двух переменных, трех, четырех, описать общий принцип для большего числа 
        {
            Console.WriteLine("Enter the first value");
            if (int.TryParse(Console.ReadLine(), out int maxValue))
            {
                Console.WriteLine("Enter the second value");
            }

            if (int.TryParse(Console.ReadLine(), out int userInput2))
            {
                Console.WriteLine("Enter the trird value");
            }

            if (int.TryParse(Console.ReadLine(), out int userInput3))
            {
                if (userInput2 > maxValue)
                {
                    maxValue = userInput2;
                }

                if (userInput3 > maxValue)
                {
                    maxValue = userInput3;
                }
            }

            Console.WriteLine($"Value {maxValue} is the biggest");
        }

        public void EvenNmbers()                    //2)	Если а – четное посчитать  а* б, иначе а+б
        {
            Console.WriteLine("Enter the first value");
            int.TryParse(Console.ReadLine(), out int userInput1);

            Console.WriteLine("Enter the second value");
            int.TryParse(Console.ReadLine(), out int userInput2);

            if ((userInput1 % 2) == 0)
            {
                Console.WriteLine($"Result: {userInput1 * userInput2}");
            }
            else
            {
                Console.WriteLine($"Result: {userInput1 + userInput2}");
            }
        }
        public void PointCoordinates()              //3)	Определить какой четверти принадлежит точка с координатами (х,у)
        {
            Console.WriteLine("Enter the x value");
            if (!int.TryParse(Console.ReadLine(), out int x))
            {
                Console.WriteLine("Error! You should enter numerical value");
                return;
            }

            Console.WriteLine("Enter the y value");
            if (!int.TryParse(Console.ReadLine(), out int y))
            {
                Console.WriteLine("Error! You should enter numerical value");
                return;
            }

            if (x > 0 && y > 0)
            {
                Console.WriteLine($"Coordinates of the point ({x},{y}) are in I plane");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine($"Coordinates of the point ({x},{y}) are in IV plane");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine($"Coordinates of the point ({x},{y}) are in II plane");
            }
            else
            {
                Console.WriteLine($"Coordinates of the point ({x},{y}) are in III plane");
            }
        }

        public void SumOfPositiveNumbers()
        {
            Console.WriteLine("Enter the first value");
            if (!int.TryParse(Console.ReadLine(), out int userInput1))
            {
                Console.WriteLine("Error! You should enter numeric value");
                return;
            }

            if (!int.TryParse(Console.ReadLine(), out int userInput2))
            {
                Console.WriteLine("Error! You should enter numeric value");
                return;
            }

            if (!int.TryParse(Console.ReadLine(), out int userInput3))
            {
                Console.WriteLine("Error! You should enter numeric value");
                return;
            }

            int positiveValue1 = 0;
            if (userInput1 > 0)
            {
                positiveValue1 = userInput1;
            }

            int positiveValue2 = 0;
            if (userInput2 > 0)
            {
                positiveValue2 = userInput2;
            }

            int positiveValue3 = 0;
            if (userInput3 > 0)
            {
                positiveValue3 = userInput3;
            }

            Console.WriteLine($"Summ of positive values: {positiveValue1 + positiveValue2 + positiveValue3}");
        }
        public void MaxExpression()
        {
            Console.WriteLine("Enter the first value");
            if (!int.TryParse(Console.ReadLine(), out int userInput1))
            {
                Console.WriteLine("Error! You should enter numeric value");
                return;
            }

            if (!int.TryParse(Console.ReadLine(), out int userInput2))
            {
                Console.WriteLine("Error! You should enter numeric value");
                return;
            }

            if (!int.TryParse(Console.ReadLine(), out int userInput3))
            {
                Console.WriteLine("Error! You should enter numeric value");
                return;
            }

            int multiplicationResult = userInput1 * userInput2 * userInput3;
            int summResult = userInput1 + userInput2 + userInput3;

            if (multiplicationResult > summResult)
            {
                Console.WriteLine($"MaxExspession: {multiplicationResult + 3}");
            }
            else
            {
                Console.WriteLine($"MaxExpression: {summResult + 3}");
            }
        }
        public void EnvelopeCapacity()
        {
            Console.WriteLine("Enter the first value");
            if (!int.TryParse(Console.ReadLine(), out int sideA))
            {
                Console.WriteLine("Error! You should enter numeric value");
                return;
            }

            if (!int.TryParse(Console.ReadLine(), out int sideB))
            {
                Console.WriteLine("Error! You should enter numeric value");
                return;
            }

            if (!int.TryParse(Console.ReadLine(), out int sideC))
            {
                Console.WriteLine("Error! You should enter numeric value");
                return;
            }

            if (!int.TryParse(Console.ReadLine(), out int sideD))
            {
                Console.WriteLine("Error! You should enter numeric value");
                return;
            }

            if (sideA > sideC && sideB > sideD)
            {
                Console.WriteLine("The first envelope will fit into the second");
            }

            else
            {
                Console.WriteLine("The first envelope will not fit into the second");
            }
        }
        public void AscendingSort()
        {
            Console.WriteLine("Chose how many values you want to sort");
            if (!int.TryParse(Console.ReadLine(), out int choseInput))
            {
                Console.WriteLine("Error! You should enter numeric value from 2 to 3");
                return;
            }

            switch (choseInput)

            {
                case 2:
                    Console.WriteLine("Enter the first value");
                    if (!int.TryParse(Console.ReadLine(), out int userInput11))
                    {
                        Console.WriteLine("Error! You should enter numeric value");
                        return;
                    }

                    Console.WriteLine("Enter the second value");
                    if (!int.TryParse(Console.ReadLine(), out int userInput12))
                    {
                        Console.WriteLine("Error! You should enter numeric value");
                        return;
                    }

                    if (userInput11 < userInput12)
                    {
                        Console.WriteLine($"Result: { userInput11}, {userInput12}");
                    }
                    else
                    {
                        Console.WriteLine($"Result: { userInput12}, {userInput11}");
                    }
                    break;

                case 3:
                    Console.WriteLine("Enter the first value");
                    if (!int.TryParse(Console.ReadLine(), out int userInput21))
                    {
                        Console.WriteLine("Error! You should enter numeric value");
                        return;
                    }

                    Console.WriteLine("Enter the second value");
                    if (!int.TryParse(Console.ReadLine(), out int userInput22))
                    {
                        Console.WriteLine("Error! You should enter numeric value");
                        return;
                    }

                    Console.WriteLine("Enter the trird value");
                    if (!int.TryParse(Console.ReadLine(), out int userInput23))
                    {
                        Console.WriteLine("Error! You should enter numeric value");
                        return;
                    }

                    if (userInput21 < userInput23 & userInput22 < userInput23)
                    {
                        if (userInput22 > userInput21)
                        {
                            Console.WriteLine($"Result: { userInput21}, {userInput22}, {userInput23}");
                        }

                        else
                        {
                            Console.WriteLine($"Result: { userInput22}, {userInput21}, {userInput23}");
                        }
                    }

                    if (userInput23 < userInput21 & userInput22 < userInput21)
                    {
                        if (userInput23 < userInput22)
                        {
                            Console.WriteLine($"Result: { userInput23}, {userInput22}, {userInput21}");
                        }

                        else
                        {
                            Console.WriteLine($"Result: { userInput22}, {userInput23}, {userInput21}");
                        }
                    }

                    if (userInput23 < userInput22 & userInput21 < userInput22)
                    {
                        if (userInput21 > userInput23)
                        {
                            Console.WriteLine($"Result: { userInput23}, {userInput21}, {userInput22}");
                        }

                        else
                        {
                            Console.WriteLine($"Result: { userInput21}, {userInput23}, {userInput22}");
                        }
                    }
                    break;

                default:
                    Console.WriteLine("Error! You've entered wrong value");
                    break;
            }

        }

        public void StudentEvaluation()
        {

            Console.WriteLine("Enter the value");
            if (!int.TryParse(Console.ReadLine(), out int userInput11))
            {
                Console.WriteLine("Error! You should enter numeric value");
                return;
            }

            if (userInput11 >= 0 && userInput11 <= 19)
            {
                Console.WriteLine($"Rating: {userInput11}    Score: F");
            }

            if (userInput11 >= 20 && userInput11 <= 39)
            {
                Console.WriteLine($"Rating: {userInput11}    Score: E");
            }

            if (userInput11 >= 40 && userInput11 <= 59)
            {
                Console.WriteLine($"Rating: {userInput11}    Score: D");
            }

            if (userInput11 >= 60 && userInput11 <= 74)
            {
                Console.WriteLine($"Rating: {userInput11}    Score: C");
            }

            if (userInput11 >= 75 && userInput11 <= 89)
            {
                Console.WriteLine($"Rating: {userInput11}    Score: B");
            }

            else if (userInput11 >= 90 && userInput11 <= 100)
            {
                Console.WriteLine($"Rating: {userInput11}    Score: A");
            }

            else
            {
                Console.WriteLine($"You've entered wrong value");
            }


        }  

    }
}
