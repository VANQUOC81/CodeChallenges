using Common.LeetCode;

namespace CodeChallenges.Tests.LeetCode
{
    [TestClass]
    public class RemoveDuplicatesfromSortedArrayTests
    {
        [TestMethod]
        public void RemoveDuplicates_FromSortedArray_ReturnsUniqueArrayCount()
        {
            // Arrange
            var codeChallenge = new RemoveDuplicatesfromSortedArray();
            const string expected = "5";

            // Act
            var actual = codeChallenge.Execute();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
