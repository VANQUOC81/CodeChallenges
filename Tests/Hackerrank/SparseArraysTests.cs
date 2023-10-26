using Common.Hackerrank;

namespace CodeChallenges.Tests.Hackerrank
{
    [TestClass]
    public class SparseArraysTests
    {
        [TestMethod]
        public void GetMatchingStrings_String_ReturnSparseArray()
        {
            // Arrange
            var codeChallenge = new SparseArrays();
            const string expected = "2,1,0";

            // Act
            var actual = codeChallenge.Execute();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
