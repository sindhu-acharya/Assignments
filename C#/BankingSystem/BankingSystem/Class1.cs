using System;

namespace BankingSystem
{
    public class Class1
    {
        public int AccountNo { get; set; }
        public string Customer { get; set; }
        public double Balance { get; set; }

        public void Withdraw(double amount)
        {
            Balance = Balance - amount;
        }

    }
}
