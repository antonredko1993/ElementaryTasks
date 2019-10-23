﻿using System;
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

    }
}