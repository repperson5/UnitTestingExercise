using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] 
        [InlineData(4,3,5,4)]
        [InlineData(1,2,3,5)]
        [InlineData(14,15,16,17)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var challenger = new Calculator();


            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = challenger.Add(num1, num2, num3);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(-3,-4,5)]
        [InlineData(10,12,13)]
        [InlineData(-2,-3,0)]
        public void SubtractTest(int minuend, int subtrahend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var challenger = new Calculator();

            //Act
            var actual = challenger.Subtract(minuend, subtrahend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2,4,5)]
        [InlineData(7,5,3)]
        [InlineData(22,23,24)]
        [InlineData(44,45,45)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var challenger = new Calculator();

            //Act
            var actual = challenger.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(5,5,-5)]
        [InlineData(12,14,16)]
        [InlineData(55,66,77)]
        [InlineData(93,94,95)]   
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var challenger = new Calculator();

            //Act
            var actual = challenger.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
