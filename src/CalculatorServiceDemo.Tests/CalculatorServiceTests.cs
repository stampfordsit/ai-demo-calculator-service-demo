using CalculatorServiceDemo;
using Xunit;

namespace BenchmarkTestProject.Tests
{
    public class SourceServiceTests
    {
        [Fact]
        public void Add_ReturnsSumOfTwoIntegers()
        {
            var service = new SourceService();
            int result = service.Add(2, 3);
            Assert.Equal(5, result);
        }
    }
}