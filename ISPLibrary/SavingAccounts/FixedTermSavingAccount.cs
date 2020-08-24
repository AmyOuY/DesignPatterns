using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPLibrary.SavingAccounts
{
    public class FixedTermSavingAccount : IFixedTermSavingAccount
    {
        public decimal InterestRate { get; set; } = 0.03M;
        public int MaturityDurationInYears { get; set; } = 2;
        public string AccountHolder { get; set; } = "Mia Terry";
        public int AccountNumber { get; set; } = 7654321;
        public decimal Balance { get; set; } = 10000M;
        public DateTime AccountOpenDate { get; set; }
        public decimal EarlyWithdrawFee { get; set; } = 100M;
    }
}
