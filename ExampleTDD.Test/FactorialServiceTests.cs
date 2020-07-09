using Xunit;

namespace ExampleTDD.Test
{
    public class FactorialServiceTests
    {
        [Fact]
        public void TestFactorialZero()
        {
            // Arrange
            var service = new FactorialService();

            // Act
            var result = service.Calculate(0);

            // Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void TestFactorialFive()
        {
            // Arrange
            var service = new FactorialService();

            // Act
            var result = service.Calculate(5);

            // Assert
            Assert.Equal(120, result);
        }

        [Theory]
        [InlineData(0, 1)]
        [InlineData(5, 120)]
        public void TestFactorial(int number, int expected)
        {
            // Arrange
            var service = new FactorialService();

            // Act
            var result = service.Calculate(number);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
