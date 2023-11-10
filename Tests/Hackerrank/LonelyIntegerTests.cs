using Common.Hackerrank;

namespace CodeChallenges.Tests.Hackerrank
{
    [TestClass]
    public class LonelyIntegerTests
    {
        [TestMethod]
        public void LonelyInteger_ArrayInt_ReturnsLonelyInteger()
        {
            // Arrange
            var codeChallenge = new LonelyInteger();
            const string expected = "4";

            // Act
            var actual = codeChallenge.Execute();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
