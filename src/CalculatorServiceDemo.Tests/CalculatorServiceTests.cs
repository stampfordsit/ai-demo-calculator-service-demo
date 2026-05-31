using CalculatorServiceDemo.Services;
using Xunit;

namespace CalculatorServiceDemo.Services.Tests
{
    public class CalculatorServiceTests
    {
        [Fact]
        public void Add_ReturnsSumOfTwoPositiveNumbers()
        {
            var service = new CalculatorService();
            int result = service.Add(2, 3);
            Assert.Equal(5, result);
        }

        [Fact]
        public void Add_ReturnsSumWhenOneNumberIsNegative()
        {
            var service = new CalculatorService();
            int result = service.Add(-2, 3);
            Assert.Equal(1, result);
        }

        [Fact]
        public void Add_ReturnsSumOfTwoNegativeNumbers()
        {
            var service = new CalculatorService();
            int result = service.Add(-2, -3);
            Assert.Equal(-5, result);
        }

        [Fact]
        public void Add_ReturnsSameNumberWhenAddingZero()
        {
            var service = new CalculatorService();
            int result = service.Add(5, 0);
            Assert.Equal(5, result);
        }
    }
}