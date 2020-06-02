using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPLibrary.SavingAccounts
{
    public class FlexibleSavingAccount : IFlexibleSavingAccount
    {
        public decimal InterestRate { get; set; } = 0.01M;
        public int MaturityDurationInYears { get; set; } = 0;
        public string AccountHolder { get; set; } = "Mia Terry";
        public int AccountNumber { get; set; } = 1234567;
        public decimal Balance { get; set; } = 1000M;
        public DateTime AccountOpenDate { get; set; }
        public DateTime TransactionDate { get; set; } = DateTime.Now;

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }
    }
}
