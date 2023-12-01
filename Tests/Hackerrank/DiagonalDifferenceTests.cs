using Common.Hackerrank;

namespace CodeChallenges.Tests.Hackerrank
{
    [TestClass]
    public class DiagonalDifferenceTests
    {
        [TestMethod]
        public void DiagonalDifference_ListofListInt_ReturnsDiagonalDifference()
        {
            // Arrange
            var codeChallenge = new DiagonalDifference();
            const string expected = "15";

            // Act
            var actual = codeChallenge.Execute();

            // Assert
             Assert.AreEqual(expected, actual);
        }
    }
}
