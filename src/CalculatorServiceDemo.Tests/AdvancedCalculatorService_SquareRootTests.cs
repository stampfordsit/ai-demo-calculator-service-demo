using CalculatorServiceDemo.Services;

namespace CalculatorServiceDemo.Services.Tests
{
    public class AdvancedCalculatorService_SquareRootTests
    {
        [Fact]
        public void SquareRoot_PositiveNumber_ReturnsCorrectResult()
        {
            var service = new AdvancedCalculatorService();
            double result = service.SquareRoot(25);
            Assert.Equal(5, result);
        }

        [Fact]
        public void SquareRoot_Zero_ReturnsZero()
        {
            var service = new AdvancedCalculatorService();
            double result = service.SquareRoot(0);
            Assert.Equal(0, result);
        }

        [Fact]
        public void SquareRoot_One_ReturnsOne()
        {
            var service = new AdvancedCalculatorService();
            double result = service.SquareRoot(1);
            Assert.Equal(1, result);
        }

        [Fact]
        public void SquareRoot_NegativeNumber_ThrowsArgumentException()
        {
            var service = new AdvancedCalculatorService();
            Assert.Throws<ArgumentException>(() => service.SquareRoot(-4));
        }

        [Fact]
        public void SquareRoot_DecimalNumber_ReturnsCorrectResult()
        {
            var service = new AdvancedCalculatorService();
            double result = service.SquareRoot(2.25);
            Assert.Equal(1.5, result);
        }
    }
}