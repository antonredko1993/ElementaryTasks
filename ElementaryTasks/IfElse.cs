﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ElementaryTasks
{
    class IfElse
    {
        public void FindMax()
        {
            Console.WriteLine("Enter the first value");
            int maxValue;
            if (int.TryParse(Console.ReadLine(), out maxValue))
            {
            Console.WriteLine("Enter the second value");
            }

            int userInput2;
            if (int.TryParse(Console.ReadLine(), out userInput2))
            {
                Console.WriteLine("Enter the trird value");
            }

            int userInput3;
            if (int.TryParse(Console.ReadLine(), out userInput3))


            if (userInput2 > maxValue)
            {
                    maxValue = userInput2;
            }
            if (userInput3 > maxValue)
            {
                maxValue = userInput3;
            }

            Console.WriteLine($"Value {maxValue} is the biggest");
        }

        /*public void EvenNmbers()
        {

        }*/

    }
}