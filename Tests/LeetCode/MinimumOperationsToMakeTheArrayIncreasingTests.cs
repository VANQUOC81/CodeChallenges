using Common.LeetCode;

namespace CodeChallenges.Tests.LeetCode
{
    [TestClass]
    public class MinimumOperationsToMakeTheArrayIncreasingTests
    {
        [TestMethod]
        public void MinOperations_IntegerList_ReturnsCountMinOperations()
        {
            // Arrange
            var codeChallenge = new MinimumOperationsToMakeTheArrayIncreasing();
            const string expected = "3";

            // Act
            var actual = codeChallenge.Execute();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
