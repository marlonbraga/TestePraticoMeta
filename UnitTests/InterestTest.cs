using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestePraticoMeta.Domain;

namespace UnitTests
{
    [TestClass]
    public class InterestTest
    {
        [TestMethod]
        public void Interest_GetInterestRate_Success()
        {
            Interest interest = new();
            var response = interest.GetInterestRate();
            Assert.IsNotNull(response);
            Assert.AreEqual(0.01, response);
        }

        [TestMethod]
        public void Interest_CalcInterest_Success()
        {
            Interest interest = new();
            double InitialValue = 100;
            int time = 5;
            var response = interest.CalcInterest(InitialValue, time);
            Assert.IsNotNull(response);
            Assert.AreEqual(105.10, response);
        }
    }
}