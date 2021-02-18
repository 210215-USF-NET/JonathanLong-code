
using System;
using Xunit;
using CalcApp;
namespace CalcTests
{
    public class CalcTests
    {
        Calculator calc = new Calculator();
        [Theory]
        [InlineData(1, 2, 4)]
        [InlineData(2, 2, 4)]
        [InlineData(10, 11, 21)]
        [InlineData(5, 6, 11)]
        public void CanAddTheory(int x, int y, int expected)
        {
            if(x + y != expected)
            {
                throw new Exception("Error - addition is not correct");
            }
            else
            {
            int result = calc.Add(x, y);
            //Assert
            Assert.Equal(expected, result);
            }
        }
        [Theory]
        [InlineData(1, 2, -1)]
        [InlineData(2, 2, 0)]
        [InlineData(20, 11, 9)]
        [InlineData(8, 6, 2)]
        public void CanSubtractTheory(int x, int y, int expected)
        {
            if(x - y != expected)
            {
                throw new Exception("Error - subtraction is not correct");
            }
            else
            {
            int result = calc.Subtract(x, y);
            //Assert
            Assert.Equal(expected, result);
            }
        }   

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(2, 2, 4)]
        [InlineData(2, 11, 22)]
        [InlineData(8, 6, 48)]
        public void CanMultiplyTheory(int x, int y, int expected)
        {
            if(x == 0)
            {
                throw new Exception("Error - x cannot be 0");
            }
            else
            {
            int result = calc.Multiply(x, y);
            //Assert
            Assert.Equal(expected, result);
            }
        } 

        [Theory]
        [InlineData(2, 1, 2)]
        [InlineData(4, 2, 2)]
        [InlineData(10, 2, 5)]
        [InlineData(8, 8, 1)]
        public void CanDivideTheory(int x, int y, int expected)
        {
            if(x == 0)
            {
                throw new Exception("Error, x cannot be 0");
            }
            else
            {
            int result = calc.Divide(x, y);
            //Assert
            Assert.Equal(expected, result);
            }
        } 

       // [Theory]
        //[InlineData(9, 34)]
        //[InlineData(2, 1)]
       // public void FibTheory(int x, int expected)
      //  {
          //  int result = calc.Fib(x);
            //Assert
          //  Assert.Equal(expected, result);
       // } 
    }
}
