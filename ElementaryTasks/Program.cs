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

            Loops loops = new Loops();
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
            //loops.Divisors();

            //8) 	Найти корень натурального числа с точностью до целого
            //loops.RootOfNaturalNumber();

            //9)    Вычислить факториал числа n. n! = 1*2*…*n-1*n;
            //loops.Factorial();

            //10)   Вычислить среднее значение чисел, не являющихся простыми, в диапазоне от 1 до n.
            //loops.AverageValue();

            //11) 	Посчитать сумму цифр заданного числа
            //loops.CalculateSum();

            //12) 	Вывести число, которое является зеркальным отображением последовательности цифр заданного числа
            //      например, задано число 123, вывести 321.    
            //loops.MirrorNumber();

            Arrays arrays = new Arrays();
            //1)	Найти минимальный элемент массива
            //arrays.MinElement();

            //2)	Найти индекс максимального элемента массива
            //arrays.IndexOfMaxValue();

            //3)	Посчитать сумму элементов массива с нечетными индексами
            //arrays.SumOfElements();

            //4)	Найти наиболее часто встречающееся значение
            //arrays.MostCommonValue();

            //5)	Сделать реверс массива (массив в обратном направлении)
            //arrays.ArrayReverse();

            //6) 	Найти все элементы, которые меньше среднего значения
            //arrays.LessThenAverageValue();

            //7)	Найти все элементы массива, для которых делителем является хотя бы один из элементов массива.
            //arrays.Divide();

            //8)	Поменять местами первую и вторую половину массива, например, для массива 1 2 3 4, результат 3 4 1 2
            //arrays.SwapPartsOfArray();

            //9)	Заполнить массив  из 100 элементов числами от 0 до 100
            //arrays.ArrayFilling();

            User user1 = new User();
            user1.FirstName = "Anton";
            user1.LastName = "Redko";
            user1.DateOfBirth = new DateTime(1993,10,31);

            User user2 = new User();
            user2.FirstName = "Ivan";
            user2.LastName = "Ivanov";
            user2.DateOfBirth = new DateTime(1992, 6, 8);

            User user3 = new User();
            user3.FirstName = "Petya";
            user3.LastName = "Petrov";
            user3.DateOfBirth = new DateTime(1999, 12, 21);

            User user4 = new User();
            user4.FirstName = "Dima";
            user4.LastName = "Korsh";
            user4.DateOfBirth = new DateTime(1989, 4, 1);

            User user5 = new User();
            user5.FirstName = "Max";
            user5.LastName = "Maximov";
            user5.DateOfBirth = new DateTime(2001, 11, 14);

            Console.WriteLine(user1.GetUserData());
            Console.WriteLine(user2.GetUserData());
            Console.WriteLine(user3.GetUserData());
            Console.WriteLine(user4.GetUserData());
            Console.WriteLine(user5.GetUserData());
        }
    }
}
