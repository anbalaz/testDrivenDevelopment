using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDrivenDevelopment;
using Xunit;

namespace TestDrivenDevelopmentTest
{
    public class CalculatorTests
    {
        private readonly Calculator calculator;

        public CalculatorTests()
        {
            calculator = new Calculator();
        }

        [Fact]
        public void ZeroEqualsZero()
        {
            calculator.Input("0");
            Assert.Equal("0", calculator.Result());
        }

        [Fact]
        public void InputNumberReturnsSameNumber()
        {
            calculator.Input("5");
            Assert.Equal("5", calculator.Result());
        }

        [Fact]
        public void ZeroPlusZero()
        {
            calculator.Input("0 + 0");
            Assert.Equal("0", calculator.Result());
        }

        [Fact]
        public void TrimBeforeAndAfterZero()
        {
            calculator.Input("  0 ");
            Assert.Equal("0", calculator.Result());
        }
    }
}
