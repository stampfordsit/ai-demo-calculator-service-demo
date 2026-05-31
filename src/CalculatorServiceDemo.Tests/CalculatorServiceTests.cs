using CalculatorServiceDemo.Services;
using Xunit;

namespace CalculatorServiceDemo.Services.Tests
{
    public class CalculatorServiceTests
    {
        [Theory]
        [InlineData(2, true)]
        [InlineData(3, true)]
        [InlineData(4, false)]
        [InlineData(17, true)]
        [InlineData(1, false)]
        [InlineData(0, false)]
        [InlineData(-5, false)]
        public void IsPrime_ReturnsExpectedResult(int number, bool expected)
        {
            var service = new CalculatorService();
            bool result = service.IsPrime(number);
            Assert.Equal(expected, result);
        }
    }
}