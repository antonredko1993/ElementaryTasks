using System;

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
            //logicalOperations.EnvelopeCapacity();

            // 7. AscendingSort  Отсортировать значения двух, трех, четырех переменных используя только условные операторы
            //logicalOperations.AscendingSort();

            //8. StudentEvaluation   рейтинг	Оценка
            /*  0 - 19    F
                20 - 39   E
                40 - 59   D
                60 - 74   C
                75 - 89   B
                90 - 100  A*/
            //logicalOperations.StudentEvaluation();

            var loops = new Loops();

            //1)	 найти сумму четных чисел и их количество в диапазоне от 1 до 99
            //loops.SumOfEvenValues();

            //2)   	Проверить простое ли число? (число называется простым, если оно делится только само на себя и на 1)
            //loops.PrimeNumber();

            /*3)    	Вывести на экран квадрат, со стороной а
            *****
            *   *
            *   *
            *   *
            *****
            */
            //loops.Square();

            /*4)	Вывести шахматную доску с заданными размерами, по принципу:
            *   *  *  *  *  *
            *  *  *  *  *  *  
            *  *  *  *  *  *
            *  *  *  *  *  *
            */
            //loops.Chess();

            // 5) 	Напишите программу, которая определяет, является ли введенное число палиндромом?     
            //(Палиндром – число или текст, которые одинаково читаются слева направо и справа налево)            - НЕ РАБОТАЕТ
            //loops.PrintPrimeNumbers();

            //6) 	Вывести все натуральные числа,  квадрат которых больше/меньше заданного числа n
            //loops.NaturalNumber();

            //7)  	Вывести все делители числа
            loops.Divisors();
        }
    }
}
