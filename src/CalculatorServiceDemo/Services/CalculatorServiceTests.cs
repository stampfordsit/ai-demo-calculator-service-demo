using CalculatorServiceDemo;
using Xunit;

namespace BenchmarkTestProject.Tests
{
    public class SourceServiceTests
    {
        [Theory]
        [InlineData(2, true)]
        [InlineData(3, true)]
        [InlineData(4, false)]
        [InlineData(17, true)]
        [InlineData(18, false)]
        [InlineData(1, false)]
        [InlineData(0, false)]
        [InlineData(-5, false)]
        public void IsPrime_ReturnsExpectedResult(int number, bool expected)
        {
            var service = new SourceService();
            bool result = service.IsPrime(number);
            Assert.Equal(expected, result);
        }
    }
}