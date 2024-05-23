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
            var inputList = new List<string>
            {
                "2", "1 2"
            };
            
            // Act
            var actual = codeChallenge.Execute(inputList);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
