using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPLibrary.CheckingAccounts
{
    public class CheckingAccount : ICheckingAccount
    {
        public decimal MonthlyFee { get; set; } = 5M;
        public decimal DailyWithdrawalLimit { get; set; } = 500M;
        public string AccountHolder { get; set; } = "Mia Terry";
        public int AccountNumber { get; set; } = 246810;
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
