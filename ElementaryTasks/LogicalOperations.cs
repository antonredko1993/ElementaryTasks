using System;
using System.Collections.Generic;
using System.Text;

namespace ElementaryTasks
{
    public class LogicalOperations
    {
        public int FindMaxValue(int userInput1, int userInput2, int userInput3)                    
        {
            int maxValue = userInput1;
            if (userInput2 > maxValue)
            {
                maxValue = userInput2;
            }

            if (userInput3 > maxValue)
            {
                maxValue = userInput3;
            }
            return maxValue;
        }

        public int GetResultOfOperationBetween2Numbers(int userInput1, int userInput2)                   
        {
            int result;
            if ((userInput1 % 2) == 0)
            {
                result = userInput1 * userInput2;
            }
            else
            {
                result = userInput1 + userInput2;
            }
            return result;
        }
        public string FindCoordinatesOfPoints(int x, int y)            
        {
            string plane;
            if (x > 0 && y > 0)
            {
                plane = "I";
            }
            else if (x > 0 && y < 0)
            {
                plane = "IV";
            }
            else if (x < 0 && y > 0)
            {
                plane = "II";
            }
            else
            {
                plane = "III";
            }
            return plane;
        }

        public int GetSumOfPositiveNumbers(int userInput1, int userInput2, int userInput3)
        {
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
            int sum = positiveValue1 + positiveValue2 + positiveValue3;
            return sum;
        }
        public int FindMaxExpression(int userInput1, int userInput2, int userInput3)
        {
            int multiplicationResult = userInput1 * userInput2 * userInput3;
            int summResult = userInput1 + userInput2 + userInput3;
            int result;

            if (multiplicationResult > summResult)
            {

                result = multiplicationResult + 3;
            }
            else
            {
                result = summResult + 3;
            }
            return result;
        }
        public bool DetermineEnvelopeCapacity(int sideA, int sideB, int sideC, int sideD)
        {
            if (sideA > sideC && sideB > sideD)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
        public string AscendingSort(int userInput1, int userInput2, int userInput3, int choseInput)
        {
            string result;
            switch (choseInput)
            {
                case 2:
                    if (userInput1 < userInput2)
                    {
                        result = $"Result: {userInput1}, {userInput2}";
                    }
                    else
                    {
                        result = $"Result: { userInput2}, {userInput1}";
                    }
                    return result;
                case 3:
                    if (userInput1 < userInput3 & userInput2 < userInput3)
                    {
                        if (userInput2 > userInput1)
                        {
                            result = $"Result: { userInput1}, {userInput2}, {userInput3}";
                        }
                        else
                        {
                            result = $"Result: { userInput2}, {userInput1}, {userInput3}";
                        }
                    }
                    else if (userInput3 < userInput1 & userInput2 < userInput1)
                    {
                        if (userInput3 < userInput2)
                        {
                            result = $"Result: { userInput3}, {userInput2}, {userInput1}";
                        }
                        else
                        {
                            result = $"Result: { userInput2}, {userInput3}, {userInput1}";
                        }
                    }
                    else if (userInput3 < userInput2 & userInput1 < userInput2)
                    {
                        if (userInput1 > userInput3)
                        {
                            result = $"Result: { userInput3}, {userInput1}, {userInput2}";
                        }
                        else
                        {
                            result = $"Result: { userInput1}, {userInput3}, {userInput2}";
                        }
                    }
                    else
                    {
                        result ="Error! You've entered wrong value";
                    }
                    return result;

                default:
                    string errorResult = "Error! You've entered wrong value";
                    return errorResult;
            }
        }

        public string StudentEvaluation(int userInput1)
        {
            string score;
            if (userInput1 >= 0 && userInput1 <= 19)
            {
                score = "F";
            }
            else if (userInput1 >= 20 && userInput1 <= 39)
            {
                score = "E";
            }
            else if (userInput1 >= 40 && userInput1 <= 59)
            {
                score = "D";
            }
            else if (userInput1 >= 60 && userInput1 <= 74)
            {
                score = "C";
            }
            else if (userInput1 >= 75 && userInput1 <= 89)
            {
                score = "B";
            }
            else
            {
                score = "A";
            }
            return score;
        }  
    }
}
