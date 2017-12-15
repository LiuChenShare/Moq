using NUnit.Framework;
using Moq;

namespace ClassLibrary1
{
    [TestFixture]
    public class CalculatorTester
    {
        // 定义mock的逻辑
        private IUSD_RMB_ExchangeRateFeed prvGetMockExchangeRateFeed()
        {
            Mock<IUSD_RMB_ExchangeRateFeed> mockObject = new Mock<IUSD_RMB_ExchangeRateFeed>();
            mockObject.Setup(m => m.GetActualUSDValue()).Returns(500);
            return mockObject.Object;
        }

        [Test]
        public void TestMethod()
        {
            // TODO: Add your test code here
            Assert.Pass("Your first passing test");
        }

        // 测试divide方法
        [Test(Description = "9除以3。预期的结果是3。")]
        public void TC1_9除以3()
        {
            IUSD_RMB_ExchangeRateFeed feed = this.prvGetMockExchangeRateFeed();
            ICalculator calculator = new Calculator(feed);
            int actualResult = calculator.Divide(9, 3);
            int expectedResult = 3;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test(Description = "把任何数除以0。 应该抛出 System.DivideByZeroException 异常。")]
        //[ExpectedException(typeof(System.DivideByZeroException))]
        public void TC2_9除以0()
        {
            IUSD_RMB_ExchangeRateFeed feed = this.prvGetMockExchangeRateFeed();
            ICalculator calculator = new Calculator(feed);
            int actualResult = calculator.Divide(9, 0);
        }

        [Test(Description = "将1美元兑换成人民币。预期的结果是500。")]
        public void TC3_将1美元兑换成人民币()
        {
            IUSD_RMB_ExchangeRateFeed feed = this.prvGetMockExchangeRateFeed();
            ICalculator calculator = new Calculator(feed);
            int actualResult = calculator.ConvertUSDtoRMB(1);
            int expectedResult = 500;
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
