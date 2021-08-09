using System;
using Xunit;
using CarsLib;

namespace CarsLibTests
{
    public class CarTests
    {

            /*
            void AddSpeed(int speed) - ensures that Speed cannot be greater 
            that 130 and never less than -10.  If greater than 130, set to 130.  
            If less than -10, set to -10.
            */

        [Theory]
        [InlineData(50, 20, 70)]
        [InlineData(120, 20, 130)]
        [InlineData(130, 10000, 130)]
        [InlineData(0, -5, -5)]
        [InlineData(-10, -10, -10)]
        [InlineData(40, -100, -10)]
        public void SetAddSpeedTest(int startingSpeed, int speedToAdd, int expected)
        {
            // Arrange 
            Car c = new Car("AAAAAA", startingSpeed);

            // Act
            c.AddSpeed(speedToAdd);


            // Assert
            Assert.Equal(c.Speed, expected);
        }

            /*
            void  SetRego(string rego) - ensures that Rego is only six character long.  
            If longer, truncate to six.  If shorter, fill up to six with 'A'.  
            This method should be used in the constructors
            */

        [Theory]
        [InlineData("BBBBBB", "BBBBBB")]
        [InlineData("CCCCCCCCCCC", "CCCCCC")]
        [InlineData("DDDD", "DDDDAA")]
        public void SetRegoTest(string newRego, string expected)
        {
            // Arange
            Car c = new Car("ZZZZZZ", 10);

            // Act
            c.SetRego(newRego);

            // Assert
            Assert.Equal(c.Rego, expected);
        }

        [Theory]
        [InlineData("BBBBBB", "BBBBBB", -20, -10)]
        [InlineData("CCCCCCCCCCC", "CCCCCC", 50, 50)]
        [InlineData("DDDD", "DDDDAA", 140, 130)]
        public void ConstructorTest(string newRego, string expectedRego, int newSpeed, int expectedSpeed)
        {
            // Arrange
            Car c = new Car(newRego, newSpeed);
        
            // Assert
            Assert.Equal(expectedRego, c.Rego);
            Assert.Equal(expectedSpeed, c.Speed);

        }


    }
}
