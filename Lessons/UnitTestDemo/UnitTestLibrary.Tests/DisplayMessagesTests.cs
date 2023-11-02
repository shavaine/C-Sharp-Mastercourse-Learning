using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

// Arrange, Act, Assert
// expected and actual
namespace UnitTestLibrary.Tests
{
    public class DisplayMessagesTests
    {
        [Fact]
        public void GreetingShouldReturnGoodMorningMessage()
        {
            // Arrange
            DisplayMessages messages = new DisplayMessages();
            string expected = "Good morning Tim";

            // Act
            string actual = messages.Greeting("Tim", 2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GreetingShouldReturnGoodAfternoonMessage()
        {
            // Arrange
            DisplayMessages messages = new DisplayMessages();
            string expected = "Good afternoon Tim";

            // Act
            string actual = messages.Greeting("Tim", 14);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Tim", 0, "Good morning Tim")]
        public void GreetingShouldReturnExpectedValue(
            string firstName,
            int hourOfDay,
            string expected)
        {
            // Arrange
            DisplayMessages messages = new DisplayMessages();
            

            // Act
            string actual = messages.Greeting(firstName, hourOfDay);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
