using Common.Hackerrank;

namespace CodeChallenges.Tests.Hackerrank
{
    [TestClass]
    public class CalPointsTests
    {
        [TestMethod]
        public void GetCalPoints_ArrayString_ReturnsCalPoints()
        {
            // Arrange
            var codeChallenge = new CalPoints();
            const string expected = "27";

            // Act
            var actual = codeChallenge.Execute();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
