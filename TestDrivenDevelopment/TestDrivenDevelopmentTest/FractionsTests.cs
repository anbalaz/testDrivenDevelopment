using TestDrivenDevelopment;
using Xunit;

namespace TestDrivenDevelopmentTest
{
    public class FractionsTests
    {
        private readonly Fractions fractions;

        public FractionsTests()
        {
            fractions = new Fractions();
        }

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(5, 5, 10)]
        [InlineData(5 / 3, 5 / 3, 2)]
        public void Test1(double first, double second, double result)
        {
            Assert.Equal(result, fractions.Plus(first, second));
        }
    }
}