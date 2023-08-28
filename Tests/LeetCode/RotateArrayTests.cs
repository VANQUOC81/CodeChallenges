using Common.LeetCode;

namespace CodeChallenges.Tests.LeetCode
{
    [TestClass]
    public class RotateArrayTests
    {
        [TestMethod]
        [DataRow(new int []{1,2,3,4,5,6,7}, 3, "5,6,7,1,2,3,4")]
        [DataRow(new int []{-1,-100,3,99}, 2, "3,99,-1,-100")]
        public void RotateArray_ListIntegers_ReturnsExpectedString(int [] input, int steps, string expected)
        {
            // Arrange
            var codeChallenge = new RotateArray
            {
                nums = input,
                k = steps
            };

            // Act
            var actual = codeChallenge.Execute();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
