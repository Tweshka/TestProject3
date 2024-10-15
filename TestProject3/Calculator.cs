using NUnit.Framework;

namespace Practices.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void SetUp()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void Additional_WhenCalled_ReturnsSum()
        {
            // Arrange
            int a = 3;
            int b = 5;

            // Act
            int result = _calculator.Additional(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(8));
        }

        [Test]
        public void Subtraction_WhenCalled_ReturnsDifference()
        {
            // Arrange
            int a = 10;
            int b = 5;

            // Act
            int result = _calculator.Subtraction(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void Miltiplication_WhenCalled_ReturnsProduct()
        {
            // Arrange
            int a = 4;
            int b = 5;

            // Act
            int result = _calculator.Miltiplication(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(20));
        }

        [Test]
        public void Division_WhenCalled_ReturnsQuotient()
        {
            // Arrange
            int a = 20;
            int b = 4;

            // Act
            int result = _calculator.Division(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void Division_ByZero_ThrowsDivideByZeroException()
        {
            // Arrange
            int a = 20;
            int b = 0;

            // Assert
            Assert.Throws<System.DivideByZeroException>(() => _calculator.Division(a, b));
        }
    }
}