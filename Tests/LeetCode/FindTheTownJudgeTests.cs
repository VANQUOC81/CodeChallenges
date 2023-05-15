using Common.LeetCode;

namespace CodeChallenges.Tests.LeetCode
{
    [TestClass]
    public class FindTheTownJudgeTests
    {
        [TestMethod]
        public void FindJudge_TotalPeopleAndTrustArray_ReturnsTownJudge()
        {
            // Arrange
            var codeChallenge = new FindTheTownJudge();
            const string expected = "2";

            // Act
            var actual = codeChallenge.Execute();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
