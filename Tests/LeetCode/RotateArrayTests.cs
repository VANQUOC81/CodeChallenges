using Common.LeetCode;

namespace CodeChallenges.Tests.LeetCode
{
    [TestClass]
    public class ThreeSumTests
    {
        [TestMethod]
        public void ThreeSum_ListIntegers_ReturnsExpectedListIntegers()
        {
            // Arrange
            var codeChallenge = new ThreeSum();
            const string expected = "-1, -1, 2-1, 0, 1";

            // Act
            var actual = codeChallenge.Execute();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
