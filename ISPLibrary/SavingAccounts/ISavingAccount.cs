using ISPLibrary.GeneralInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPLibrary.SavingAccounts
{
    public interface ISavingAccount : IAccount
    {
        decimal InterestRate { get; set; }
        int MaturityDurationInYears { get; set; }
    }
}
