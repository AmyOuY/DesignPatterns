using ISPLibrary.GeneralInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPLibrary.CheckingAccounts
{
    public interface ICheckingAccount : IAccount, ITransaction
    {
        decimal MonthlyFee { get; set; }
        decimal DailyWithdrawalLimit { get; set; }
    }
}
