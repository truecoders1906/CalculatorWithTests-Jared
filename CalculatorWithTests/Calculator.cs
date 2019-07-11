
namespace CalculatorWithTests
{
    public class Calculator
    {
        public decimal AddNumbersTogether(decimal number1, decimal number2)
        {
            return number1 + number2;
        }
        public decimal SubtractNumbers(decimal number1, decimal number2)
        {
            return number1 - number2;
        }
        public decimal MulitplyNumbers(decimal num1, decimal num2)
        {
            return num1 * num2;
        }
        public decimal DivideNumbers(decimal num1,decimal num2)
        {
            return num1 / num2;
        }
        public int Factorial(int number)
        {
            int result = number;
            if (result == 0)
            {
                return 1;
            }
            else if (number < 0)
            {
                return 0;
            }
            for (int i = 1; i < number; i++)
            {
               
                result = result * i;
            }
            return result;
        }
    }
}
