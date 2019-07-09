using System;
using Xunit;
using CalculatorWithTests;

namespace CalculatorTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(3, 2, 5)]
        [InlineData(5, 2.6, 7.6)]
        public void AddNumbersTogether(decimal number1, decimal number2, decimal expected)
        {
            //Arrange
            Calculator cal = new Calculator();

            //Act
            decimal actual = cal.AddNumbersTogether(number1, number2);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(8, 4, 4)]
        [InlineData(4, -16, 20)]
        public void SubtractNumbers(decimal number1, decimal number2, decimal expected)
        {
            //Arrange
            Calculator cal = new Calculator();

            //Act
            decimal actual = cal.SubtractNumbers(number1, number2);

            //Assert
            Assert.Equal(expected, actual);

        }
        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(3, 2.1, 6.3)]
        public void MulitplyNumbers(decimal num1, decimal num2, decimal expected)
        {
            //Arrange
            Calculator cal = new Calculator();

            //Act
            decimal actual = cal.MulitplyNumbers(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(4,2,2)]
        public void DivideNumbers(decimal num1, decimal num2, decimal expected)
        {
            //Arrange
            Calculator cal = new Calculator();

            //Act
            decimal actual = cal.DivideNumbers(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4,24)]
        public void Factorial(int number, int expected)
        {
            //Arrange
            Calculator cal = new Calculator();

            //Act
            int actual = cal.Factorial(number);

            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
