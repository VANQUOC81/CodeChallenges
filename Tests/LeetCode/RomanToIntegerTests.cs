using Common.LeetCode;

namespace CodeChallenges.Tests.LeetCode
{
    [TestClass]
    public class RomanToIntegerTests
    {
        [TestMethod]
        public void ConvertTime_RomanLiteral_ReturnsInteger()
        {
            // Arrange
            var codeChallenge = new RomanToInteger();
            const string expected = "1994";

            // Act
            var actual = codeChallenge.Execute();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
