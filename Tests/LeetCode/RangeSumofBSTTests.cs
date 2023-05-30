using Common.LeetCode;

namespace CodeChallenges.Tests.LeetCode
{
    [TestClass]
    public class RangeSumofBSTTests
    {
        [TestMethod]
        public void RangeSumofBST_InputBinarySearchTree_ReturnsRangeSumOfBST()
        {
            // Arrange
            var codeChallenge = new RangeSumofBST();
            const string expected = "32";

            // Act
            var actual = codeChallenge.Execute();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
