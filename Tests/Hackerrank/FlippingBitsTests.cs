using Common.Hackerrank;

namespace CodeChallenges.Tests.Hackerrank
{
    [TestClass]
    public class FlippingBitsTests
    {
        [TestMethod]
        public void FlippingBits_LongValue_ReturnsFlippedBitsLongValue()
        {
            // Arrange
            var codeChallenge = new FlippingBits();
            const string expected = "2147483648";

            // Act
            var actual = codeChallenge.Execute();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
