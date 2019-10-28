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

            var cicles = new Cicles();

            //1)	 найти сумму четных чисел и их количество в диапазоне от 1 до 99
            //cicles.SumOfEvenValues();

            //2)   	Проверить простое ли число? (число называется простым, если оно делится только само на себя и на 1)
            cicles.PrimeNumber();
        }
    }
}
