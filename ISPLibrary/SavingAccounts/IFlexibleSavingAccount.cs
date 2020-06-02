using ISPLibrary.GeneralInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPLibrary.SavingAccounts
{
    public interface IFlexibleSavingAccount : ISavingAccount, ITransaction
    {
    }
}
