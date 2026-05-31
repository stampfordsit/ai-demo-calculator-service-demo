using BenchmarkSourceProject;
using Xunit;

namespace BenchmarkTestProject.Tests
{
    public class SourceServiceTests
    {
        [Fact]
        public void Add_ReturnsSumOfTwoPositiveNumbers()
        {
            var service = new SourceService();
            int result = service.Add(2, 3);
            Assert.Equal(5, result);
        }

        [Fact]
        public void Add_ReturnsSumWhenOneNumberIsNegative()
        {
            var service = new SourceService();
            int result = service.Add(-1, 4);
            Assert.Equal(3, result);
        }

        [Fact]
        public void Add_ReturnsSumWhenBothNumbersAreNegative()
        {
            var service = new SourceService();
            int result = service.Add(-2, -3);
            Assert.Equal(-5, result);
        }

        [Fact]
        public void Add_ReturnsSameNumberWhenAddingZero()
        {
            var service = new SourceService();
            int result = service.Add(7, 0);
            Assert.Equal(7, result);
        }
    }
}