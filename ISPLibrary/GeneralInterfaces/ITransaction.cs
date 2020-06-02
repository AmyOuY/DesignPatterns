using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPLibrary.GeneralInterfaces
{
    public interface ITransaction
    {
        DateTime TransactionDate { get; set; }
        void Deposit(decimal amount);
        void Withdraw(decimal amount);
    }
}
