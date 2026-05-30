using BenchmarkSourceProject;
using Xunit;

namespace BenchmarkTestProject.Tests
{
    public class SourceServiceTests
    {
        [Fact]
        public void Multiply_ReturnsProduct_WhenGivenTwoIntegers()
        {
            var service = new SourceService();
            int result = service.Multiply(3, 4);
            Assert.Equal(12, result);
        }

        [Fact]
        public void Multiply_ReturnsZero_WhenOneOperandIsZero()
        {
            var service = new SourceService();
            int result = service.Multiply(0, 5);
            Assert.Equal(0, result);
        }

        [Fact]
        public void Multiply_ReturnsNegativeProduct_WhenOperandsHaveDifferentSigns()
        {
            var service = new SourceService();
            int result = service.Multiply(-2, 3);
            Assert.Equal(-6, result);
        }

        [Fact]
        public void Multiply_ReturnsPositiveProduct_WhenBothOperandsAreNegative()
        {
            var service = new SourceService();
            int result = service.Multiply(-2, -3);
            Assert.Equal(6, result);
        }
    }
}