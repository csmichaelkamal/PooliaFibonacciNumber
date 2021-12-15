using NUnit.Framework;

namespace Poolia.CodeTest.FibonacciNumberProblem.Tests
{
    public class FibonacciNumberTests
    {
        private FibonacciNumber fibonacciNumber;

        [SetUp]
        public void Setup()
        {
            fibonacciNumber = new FibonacciNumber();
        }

        [Test]
        public void FibonacciNumber_WhenPassPositionZero_ShouldReturnOne()
        {
            // Arrange
            var position = 0;

            // Act
            var actual = fibonacciNumber.GetFibonacciByPosition(position);

            // Assert
            Assert.AreEqual(1, actual);
        }

        [Test]
        [TestCase(2, 1)]
        [TestCase(3, 2)]
        [TestCase(4, 3)]
        [TestCase(5, 5)]
        [TestCase(6, 8)]
        public void FibonacciNumber_WhenPassPosition_ShouldReturnExpectedFibonacciNumber(int position, int expectedFibonacciNumber)
        {
            // Arrange
            // Act
            var actual = fibonacciNumber.GetFibonacciByPosition(position);

            // Assert
            Assert.AreEqual(expectedFibonacciNumber, actual);
        }
    }
}