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
        [InlineData(6.465,3.952,10.417)]
        
        [InlineData(0,3,3)]
        [InlineData(0,0,0)]
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
        [InlineData(27,5,22)]
        [InlineData(-24,-24,0)]
        [InlineData(0,-8,8)]
        [InlineData(-9,9,-18)]
        [InlineData(25,-5,30)]
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
        [InlineData(9,9,81)]
        [InlineData(-6,6,-36)]
        [InlineData(-5,-5,25)]
        [InlineData(0,280,0)]
        [InlineData(-5,28,-140)]
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
        [InlineData(2,4,0.5)]
        [InlineData(36,6,6)]
        [InlineData(4,0.5,8)]
        [InlineData(26,.25,104)]
        [InlineData(.14,10,0.014)]
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
        [InlineData(6,720)]
        [InlineData(5,120)]
        [InlineData(9, 362880)]
        [InlineData(0,1)]
        [InlineData(-5,0)]

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
