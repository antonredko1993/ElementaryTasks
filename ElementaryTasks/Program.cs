﻿using System;

namespace ElementaryTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            var logicalOperations = new LogicalOperations();

            // 1. FindMax (1)	(Найти наибольшее значение из двух переменных, трех, четырех, описать общий принцип для большего числа)
            //logicalOperations.FindMax();

            // 2.EvenNumbers (2)	(Если а – четное посчитать  а*б, иначе а+б)
            //logicalOperations.EvenNmbers();

            // 3.PointCoordinates(3) 	Определить какой четверти принадлежит точка с координатами (х,у))
            //logicalOperations.PointCoordinates();

            // 4.SumOfPositiveNumbers    4)	Найти суммы только положительных из трех чисел
            //logicalOperations.SumOfPositiveNumbers();

            // 5.MaxExpression    5)    Посчитать выражение макс(а*б*с,  а+б+с)+3
            //logicalOperations.MaxExpression();

            // 6.EnvelopeCapasity     6)	Есть два конверта со сторонами (а,б) и (с,д) определить, можно ли один конверт вложить в другой
            logicalOperations.EnvelopeCapacity();
        }
    }
}
