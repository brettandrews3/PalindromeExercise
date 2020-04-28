using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("Racecar", true)]
        [InlineData("toot", true)]
        [InlineData("boob", true)]
        [InlineData("return", false)]
        [InlineData("Leffel", true)]
        [InlineData("night", false)]
        [InlineData("shift", false)]
        [InlineData("tacocat", true)]
        public void MyTest(string word, bool expected)
        {
            // Arrange
            var tester = new WordSmith(); // Creating new instance of Palindrome class
            // Act
            var actual = tester.IsAPalindrome(word);
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
