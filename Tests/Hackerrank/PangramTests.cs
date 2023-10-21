using Common.Hackerrank;

namespace CodeChallenges.Tests.Hackerrank
{
    [TestClass]
    public class PangramTests
    {
        [TestMethod]
        public void GetPangram_String_ReturnsPangram()
        {
            // Arrange
            var codeChallenge = new Pangram();
            const string expected = "not pangram";

            // Act
            var actual = codeChallenge.Execute();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}