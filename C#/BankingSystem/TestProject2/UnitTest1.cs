using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankingSystem;

namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 sb = new Class1();
            sb.Balance = 10000;
            sb.Withdraw(1000);
            Assert.AreEqual(9000, sb.Balance);
        }

        [TestMethod]
        [ExpectedExceptionBase(typeof(LowBalanceException))]
        public void WithdrawAmountMore
        {
            Class1 sb = new SavingsBankAccount();
            sb.Balance = 10000;
            sb.WithDraw(11000);
            Assert.AreEqual(10000,sb.Balance);)
        }
    }
}
