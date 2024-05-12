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
            string input = "-1,0,1,2,-1,-4";
            const string expected = "-1, -1, 2-1, 0, 1";

            // Act
            string actual = new ThreeSum().Execute(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
