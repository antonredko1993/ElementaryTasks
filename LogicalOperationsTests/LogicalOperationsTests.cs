using ElementaryTasks;
using NUnit.Framework;

namespace LogicalOperationsTests
{
    [TestFixture]
    public class Tests
    {
        [TestCase(10, 20, 30, 30)]
        [TestCase(10, 30, 20, 30)]
        [TestCase(30, 20, 10, 30)]
        public void FindMaxValueBetween3Values(int a, int b, int c, int expected)
        {
            //arrange
            LogicalOperations x = new LogicalOperations();

            //act
            int result = x.FindMaxValue(a, b, c);

            //assert
            Assert.AreEqual(expected, result);
        }

        [TestCase(10, 20, 200)]
        [TestCase(11, 30, 41)]
        [TestCase(10, 21, 210)]
        [TestCase(11, 21, 32)]
        public void If_a_evenValue_multiply_if_not_sum(int a, int b, int expected)
        {
            //arrange
            LogicalOperations x = new LogicalOperations();

            //act
            int result = x.GetResultOfOperationBetween2Numbers(a, b);

            //assert
            Assert.AreEqual(expected, result);
        }

        [TestCase(1, 1, "I")]
        [TestCase(1, -1, "IV")]
        [TestCase(-1, 1, "II")]
        [TestCase(-1, -1, "III")]
        public void FindCoordinatesOfPoints_a_b(int a, int b, string expected)
        {
            //arrange
            LogicalOperations x = new LogicalOperations();

            //act
            string result = x.FindCoordinatesOfPoints(a, b);

            //assert
            Assert.AreEqual(expected, result);
        }

        [TestCase(1, 1, -1, 2)]
        [TestCase(1, -1, 1, 2)]
        [TestCase(-1, 1, 1, 2)]
        [TestCase(1, 1, 1, 3)]
        [TestCase(-1, -1, -1, 0)]
        public void GetSumOfPositiveNumbers_a_b_c(int a, int b, int c, int expected)
        {
            //arrange
            LogicalOperations x = new LogicalOperations();

            //act
            int result = x.GetSumOfPositiveNumbers(a, b, c);

            //assert
            Assert.AreEqual(expected, result);
        }

        [TestCase(1, 1, 1, 6)]
        [TestCase(2, 2, 2, 11)]
        [TestCase(2, -3, 2, 4)]
        [TestCase(-2, -1, 2, 7)]
        public void FindMaxExpressionBetweenMultiply_and_sum_of_a_b_c_and_add_3(int a, int b, int c, int expected)
        {
            //arrange
            LogicalOperations x = new LogicalOperations();

            //act
            int result = x.FindMaxExpression(a, b, c);

            //assert
            Assert.AreEqual(expected, result);
        }

        [TestCase(2, 2, 1, 1, true)]
        [TestCase(2, 2, 2, 2, false)]
        [TestCase(3, 3, 3, 2, false)]
        [TestCase(3, 3, 2, 4, false)]
        [TestCase(3, 3, 3, 3, false)]
        [TestCase(1, 1, 4, 4, false)]
        public void envelope_c_d_fits_into_envelope_a_b(int a, int b, int c, int d, bool expected)
        {
            //arrange
            LogicalOperations x = new LogicalOperations();

            //act
            bool result = x.DetermineEnvelopeCapacity(a, b, c, d);

            //assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void AscendingSort_a_b_c()
        {
            //arrange
            int a = 3;
            int b = 4;
            int c = 5;
            int choseInput = 3;
            string expected = $"Result: 3, 4, 5";

            LogicalOperations x = new LogicalOperations();

            //act
            string result = x.AscendingSort(a, b, c, choseInput);

            //assert
            Assert.AreEqual(expected, result);
        }

        [TestCase(19, "F")]
        [TestCase(21, "E")]
        [TestCase(58, "D")]
        [TestCase(70, "C")]
        [TestCase(75, "B")]
        [TestCase(100, "A")]
        public void GetStudentEvaluation(int a, string expected)
        {
            //arrange
            LogicalOperations x = new LogicalOperations();

            //act
            string result = x.StudentEvaluation(a);

            //assert
            Assert.AreEqual(expected, result);
        }
    }
}