using Common.LeetCode;

namespace CodeChallenges.Tests.LeetCode
{
    [TestClass]
    public class BestTimetoBuyandSellStockIITests
    {
        [TestMethod]
        public void CalculateMaxProfit_PricesArray_ReturnsMaxProfit()
        {
            // Arrange
            var codeChallenge = new BestTimetoBuyandSellStockII();
            const string expected = "7";

            // Act
            var actual = codeChallenge.Execute();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
