using Xunit;

namespace ExampleTDD.Test
{
    public class FactorialServiceTests
    {
        [Fact]
        public void TestFactorialZero()
        {
            var service = new FactorialService();

            var result = service.Calculate(0);

            Assert.Equal(1, result);
        }

        [Fact]
        public void TestFactorialFive()
        {
            var service = new FactorialService();

            var result = service.Calculate(5);

            Assert.Equal(120, result);
        }
    }
}
