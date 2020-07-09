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
    }
}
