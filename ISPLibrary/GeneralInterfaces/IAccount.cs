using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPLibrary.GeneralInterfaces
{
    public interface IAccount
    {
        string AccountHolder { get; set; }
        int AccountNumber { get; set; }
        decimal Balance { get; set; }
        DateTime AccountOpenDate { get; set; }
    }
}
