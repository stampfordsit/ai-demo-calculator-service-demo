using CalculatorServiceDemo.Services;
using Xunit;

namespace CalculatorServiceDemo.Services.Tests
{
    public class CalculatorService_AddTests
    {
        [Fact]
        public void Add_PositiveNumbers_ReturnsSum()
        {
            var service = new CalculatorService();
            int result = service.Add(2, 3);
            Assert.Equal(5, result);
        }

        [Fact]
        public void Add_NegativeNumbers_ReturnsSum()
        {
            var service = new CalculatorService();
            int result = service.Add(-2, -3);
            Assert.Equal(-5, result);
        }

        [Fact]
        public void Add_PositiveAndNegative_ReturnsSum()
        {
            var service = new CalculatorService();
            int result = service.Add(5, -3);
            Assert.Equal(2, result);
        }

        [Fact]
        public void Add_Zero_ReturnsOtherNumber()
        {
            var service = new CalculatorService();
            int result = service.Add(0, 7);
            Assert.Equal(7, result);
        }
    }
}