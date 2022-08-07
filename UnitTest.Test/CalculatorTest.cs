using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestApp;
using Xunit;

namespace UnitTest.Test
{
    public class CalculatorTest
    {
        [Fact]
        public void AddTest()
        {
            //Arrange
            int a = 5;
            int b = 10;
            var calculator = new Calculator();
            //Act
            var total = calculator.add(a, b);
            //Assert
            Assert.Equal<int>(15, total);

        }
    }
}
