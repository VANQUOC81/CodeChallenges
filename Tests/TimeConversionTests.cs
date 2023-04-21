using Common.Hackerrank;

namespace CodeChallenges.Tests
{
    [TestClass]
    public class TimeConversionTests
    {
        [TestMethod]
        public void ConvertTime_StringMeridiemTime_Returns24HoursFormat()
        {
            // Arrange
            var codeChallenge = new TimeConversion();
            const string expected = "19:05:45";

            // Act
            var actual = codeChallenge.Execute();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}