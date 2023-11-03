using HomeworkUnitTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HomeworkUnitTest.tests
{
    public class CalculationsTests
    {
        [Theory]
        [InlineData(5,5,10)]
        public void AddShouldReturnExpectedValue(double x, double y, double expected)
        {
            // Arrange
            Calculations calc = new Calculations();

            // Act
            double result = calc.Add(x, y);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(5, 5, 0)]
        public void SubtractShouldReturnExpectedValue(double x, double y, double expected)
        {
            // Arrange
            Calculations calc = new Calculations();

            // Act
            double result = calc.Subtract(x, y);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(5, 5, 25)]
        public void MultiplyShouldReturnExpectedValue(double x, double y, double expected)
        {
            // Arrange
            Calculations calc = new Calculations();

            // Act
            double result = calc.Multiply(x, y);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(10, 2, 5)]
        public void DivideShouldReturnExpectedValue(double x, double y, double expected)
        {
            // Arrange
            Calculations calc = new Calculations();

            // Act
            double result = calc.Divide(x, y);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
