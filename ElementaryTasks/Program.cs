using System;

namespace ElementaryTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            var logicalOperations = new LogicalOperations();

            // 1.(Найти наибольшее значение из двух переменных, трех, четырех, описать общий принцип для большего числа)
            //Console.WriteLine("Enter the first value");
            //if (int.TryParse(Console.ReadLine(), out int userInput1))
            //{
            //    Console.WriteLine("Enter the second value");
            //}
            //if (int.TryParse(Console.ReadLine(), out int userInput2))
            //{
            //    Console.WriteLine("Enter the trird value");
            //}
            //if (int.TryParse(Console.ReadLine(), out int userInput3))
            //{
            //    int maxValue = logicalOperations.FindMaxValue(userInput1, userInput2, userInput3);
            //    Console.WriteLine($"Value {maxValue} is the biggest");
            //}

            // 2.	(Если а – четное посчитать  а*б, иначе а+б)
            //Console.WriteLine("Enter the first value");
            //int.TryParse(Console.ReadLine(), out int userInput1);

            //Console.WriteLine("Enter the second value");
            //int.TryParse(Console.ReadLine(), out int userInput2);

            //int result = logicalOperations.GetResultOfOperationBetween2Numbers(userInput1, userInput2);
            //Console.WriteLine($"Result: {result}");

            // 3.Определить какой четверти принадлежит точка с координатами (х,у))
            //Console.WriteLine("Enter the x value");
            //if (!int.TryParse(Console.ReadLine(), out int x))
            //{
            //    Console.WriteLine("Error! You should enter numerical value");
            //    return;
            //}

            //Console.WriteLine("Enter the y value");
            //if (!int.TryParse(Console.ReadLine(), out int y))
            //{
            //    Console.WriteLine("Error! You should enter numerical value");
            //    return;
            //}

            //string plane = logicalOperations.FindCoordinatesOfPoints(x,y);
            //Console.WriteLine($"Coordinates of the point ({x},{y}) are in {plane} plane");

            // 4.Найти суммы только положительных из трех чисел
            //Console.WriteLine("Enter the first value");
            //if (!int.TryParse(Console.ReadLine(), out int userInput1))
            //{
            //    Console.WriteLine("Error! You should enter numeric value");
            //    return;
            //}
            //if (!int.TryParse(Console.ReadLine(), out int userInput2))
            //{
            //    Console.WriteLine("Error! You should enter numeric value");
            //    return;
            //}
            //if (!int.TryParse(Console.ReadLine(), out int userInput3))
            //{
            //    Console.WriteLine("Error! You should enter numeric value");
            //    return;
            //}

            //int sum = logicalOperations.GetSumOfPositiveNumbers(userInput1, userInput2, userInput3);
            //Console.WriteLine($"Summ of positive numbers: {sum}");

            // 5.Посчитать выражение макс(а*б*с,  а+б+с)+3
            //Console.WriteLine("Enter the first value");
            //if (!int.TryParse(Console.ReadLine(), out int userInput1))
            //{
            //    Console.WriteLine("Error! You should enter numeric value");
            //    return;
            //}
            //if (!int.TryParse(Console.ReadLine(), out int userInput2))
            //{
            //    Console.WriteLine("Error! You should enter numeric value");
            //    return;
            //}
            //if (!int.TryParse(Console.ReadLine(), out int userInput3))
            //{
            //    Console.WriteLine("Error! You should enter numeric value");
            //    return;
            //}

            //int result = logicalOperations.FindMaxExpression(userInput1, userInput2, userInput3);
            //Console.WriteLine($"MaxExspession: {result}");

            // 6.Есть два конверта со сторонами (а,б) и (с,д) определить, можно ли один конверт вложить в другой

            //Console.WriteLine("EEnter the side A");
            //if (!int.TryParse(Console.ReadLine(), out int sideA))
            //{
            //    Console.WriteLine("Error! You should enter numeric value");
            //    return;
            //}
            //Console.WriteLine("Enter the side B");
            //if (!int.TryParse(Console.ReadLine(), out int sideB))
            //{
            //    Console.WriteLine("Error! You should enter numeric value");
            //    return;
            //}
            //Console.WriteLine("Enter the side C");
            //if (!int.TryParse(Console.ReadLine(), out int sideC))
            //{
            //    Console.WriteLine("Error! You should enter numeric value");
            //    return;
            //}
            //Console.WriteLine("Enter the side D");
            //if (!int.TryParse(Console.ReadLine(), out int sideD))
            //{
            //    Console.WriteLine("Error! You should enter numeric value");
            //    return;
            //}

            //bool capacity = logicalOperations.DetermineEnvelopeCapacity(sideA, sideB, sideC, sideD);
            //if (capacity == true)
            //{
            //    Console.WriteLine("The first envelope will fit into the second");
            //}
            //else
            //{
            //    Console.WriteLine("The first envelope will not fit into the second");
            //}

            // 7. Отсортировать значения двух, трех, четырех переменных используя только условные операторы
            //Console.WriteLine("Chose how many values you want to sort");
            //if (!int.TryParse(Console.ReadLine(), out int choseInput))
            //{
            //    Console.WriteLine("Error! You should enter numeric value from 2 to 3");
            //    return;
            //}
            //int userInput1 = 0;
            //int userInput2 = 0;
            //int userInput3 = 0;
            //if (choseInput == 2)
            //{
            //    Console.WriteLine("Enter the first value");
            //    if (!int.TryParse(Console.ReadLine(), out userInput1))
            //    {
            //        Console.WriteLine("Error! You should enter numeric value");
            //        return;
            //    }

            //    Console.WriteLine("Enter the second value");
            //    if (!int.TryParse(Console.ReadLine(), out userInput2))
            //    {
            //        Console.WriteLine("Error! You should enter numeric value");
            //        return;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Enter the first value");
            //    if (!int.TryParse(Console.ReadLine(), out userInput1))
            //    {
            //        Console.WriteLine("Error! You should enter numeric value");
            //        return;
            //    }

            //    Console.WriteLine("Enter the second value");
            //    if (!int.TryParse(Console.ReadLine(), out userInput2))
            //    {
            //        Console.WriteLine("Error! You should enter numeric value");
            //        return;

            //    }
            //    Console.WriteLine("Enter the trird value");
            //    if (!int.TryParse(Console.ReadLine(), out userInput3))
            //    {
            //        Console.WriteLine("Error! You should enter numeric value");
            //        return;
            //    }
            //}
            //string result = logicalOperations.AscendingSort(userInput1, userInput2, userInput3, choseInput);
            //Console.WriteLine(result);

            //8.рейтинг	Оценка
            /*  0 - 19    F
                20 - 39   E
                40 - 59   D
                60 - 74   C
                75 - 89   B
                90 - 100  A*/

            //Console.WriteLine("Enter the value");
            //if (!int.TryParse(Console.ReadLine(), out int userInput1))
            //{
            //    Console.WriteLine("Error! You should enter numeric value");
            //    return;
            //}

            //string score = logicalOperations.StudentEvaluation(userInput1);
            //Console.WriteLine($"Rating: {userInput1}    Score: {score}");

            Loops loops = new Loops();
            //1)	 найти сумму четных чисел и их количество в диапазоне от 1 до 99

            //var result = loops.SumOfEvenValues();
            //for (int i = 0; i < result.EvenValues.Length; i++)
            //{
            //    Console.WriteLine(result.EvenValues[i]);
            //}
            //Console.WriteLine($"Summ: {result.SumOfEvenValues}");
            //Console.WriteLine($"Count: {result.CountOfEvenValues}");

            //2)   	Проверить простое ли число? (число называется простым, если оно делится только само на себя и на 1)

            //Console.WriteLine("Enter the value");
            //int.TryParse(Console.ReadLine(), out int userInput1);
            //if (loops.PrimeNumber(userInput1) == true)
            //{
            //    Console.WriteLine($"{userInput1} is a prime number");
            //}
            //else
            //{
            //    Console.WriteLine($"{userInput1} isn't a prime number");
            //}

            /*3)    	Вывести на экран квадрат, со стороной а
            *****
            *   *
            *   *
            *   *
            *****
            */

            //Console.WriteLine("Enter the value");
            //int.TryParse(Console.ReadLine(), out int userInput);

            //var result = loops.Square(userInput);
            //for (int row = 0; row < userInput; row++)
            //{
            //    for (int column = 0; column < userInput; column++)
            //    {
            //        Console.Write(result[row,column]);
            //    }
            //    Console.WriteLine();
            //}

            /*4)	Вывести шахматную доску с заданными размерами, по принципу:
                    *  *  *  *  *  *
                      *  *  *  *  *  *  
                    *  *  *  *  *  *
                      *  *  *  *  *  *
                    */
            //Console.WriteLine("Enter number of rows");
            //int.TryParse(Console.ReadLine(), out int userInput1);

            //if (userInput1 <= 1 || userInput1 % 1 != 0)
            //{
            //    Console.WriteLine($"{userInput1} isn't correct value");
            //}
            //else
            //{
            //    Console.WriteLine("Enter number of columns");
            //}
            //int.TryParse(Console.ReadLine(), out int userInput2);

            //var result = loops.Chess(userInput1,userInput2);
            //for (int row = 0; row < userInput1; row++)
            //{
            //    for (int column = 0; column < userInput2; column++)
            //    {
            //        Console.Write(result[row,column]);
            //    }
            //    Console.WriteLine();
            //}


            // 5) Вывести все простые числа в диапазоне от 2 до n

            //Console.WriteLine("Enter the value");
            //int.TryParse(Console.ReadLine(), out int userInput);

            //var result = loops.GetPrimeNumbers(userInput);
            //for (int i = 0; i <result.Length ; i++)
            //{
            //    Console.WriteLine(result[i]);
            //}

            //6) 	Вывести все натуральные числа,  квадрат которых больше/меньше заданного числа n

            //Console.WriteLine("Enter the value");
            //int.TryParse(Console.ReadLine(), out int userInput);

            //var result = loops.NaturalNumber(userInput);
            //foreach (var i in result )
            //{
            //    Console.WriteLine(i);
            //}

            //7)  	Вывести все делители числа

            //Console.WriteLine("Enter the value");
            //int.TryParse(Console.ReadLine(), out int userInput);
            //var result = loops.FindDivisorsOfValue(userInput);
            //foreach (var i in result)
            //{
            //    Console.WriteLine(i);
            //}

            //8) 	Найти корень натурального числа с точностью до целого
            //Console.WriteLine("Enter the value");
            //int.TryParse(Console.ReadLine(), out int userInput);

            //var result = loops.RootOfNaturalNumber(userInput);
            //Console.WriteLine($"Root of {userInput}: {result}");

            //9)    Вычислить факториал числа n. n! = 1*2*…*n-1*n;

            //Console.WriteLine("Enter the value");
            //int.TryParse(Console.ReadLine(), out int userInput);
            //var result = loops.FindFactorial(userInput);
            //Console.WriteLine($"Factoiral of {userInput}: {result}");

            //10)   Вычислить среднее значение чисел, не являющихся простыми, в диапазоне от 1 до n.

            //Console.WriteLine("Enter the value");
            //int.TryParse(Console.ReadLine(), out int userInput);
            //var result = loops.FindAverageValue(userInput);
            //Console.WriteLine($"Average value is: {result}");

            //11) 	Посчитать сумму цифр заданного числа

            //Console.WriteLine("Enter the value");
            //int.TryParse(Console.ReadLine(), out int userInput);
            //var result = loops.CalculateSumOfNumbersOfValue(userInput);
            //Console.WriteLine($"Sum of number {userInput} is: {result}");

            //12) 	Вывести число, которое является зеркальным отображением последовательности цифр заданного числа
            //      например, задано число 123, вывести 321.    

            //Console.WriteLine("Enter the value");
            //int.TryParse(Console.ReadLine(), out int userInput);
            //var result = loops.GetMirrorNumber(userInput);
            //Console.WriteLine($"Mirror number of {userInput} is: {result}");

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

            //User user1 = new User();
            //user1.FirstName = "Anton";
            //user1.LastName = "Redko";
            //user1.DateOfBirth = new DateTime(1993, 10, 31);

            //User user2 = new User();
            //user2.FirstName = "Ivan";
            //user2.LastName = "Ivanov";
            //user2.DateOfBirth = new DateTime(1992, 6, 8);

            //User user3 = new User();
            //user3.FirstName = "Petya";
            //user3.LastName = "Petrov";
            //user3.DateOfBirth = new DateTime(1999, 12, 21);

            //User user4 = new User();
            //user4.FirstName = "Dima";
            //user4.LastName = "Korsh";
            //user4.DateOfBirth = new DateTime(1989, 4, 1);

            //User user5 = new User();
            //user5.FirstName = "Max";
            //user5.LastName = "Maximov";
            //user5.DateOfBirth = new DateTime(2001, 11, 14);

            //Console.WriteLine(user1.GetUserData());
            //Console.WriteLine(user2.GetUserData());
            //Console.WriteLine(user3.GetUserData());
            //Console.WriteLine(user4.GetUserData());
            //Console.WriteLine(user5.GetUserData());
        }
    }
}
