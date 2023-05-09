using Common.LeetCode;

namespace CodeChallenges.Tests.LeetCode
{
    [TestClass]
    public class IntersectionofTwoArrayIITests
    {
        [TestMethod]
        public void Intersect_TwoIntegerLists_ReturnsIntersectedValues()
        {
            // Arrange
            var codeChallenge = new IntersectionofTwoArrayII();
            const string expected = "2,2";

            // Act
            var actual = codeChallenge.Execute();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
