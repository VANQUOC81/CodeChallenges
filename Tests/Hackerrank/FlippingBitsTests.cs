using Common.Hackerrank;

namespace CodeChallenges.Tests.Hackerrank
{
    [TestClass]
    public class FlippingBitsTests
    {
        [TestMethod]
        public void CountingSort_ListInt_ReturnsCountFrequency()
        {
            // Arrange
            var codeChallenge = new FlippingBits();
            const string expected = "";

            // Act
            var actual = codeChallenge.Execute();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
