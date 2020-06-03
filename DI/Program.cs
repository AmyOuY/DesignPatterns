using DILibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI
{
    class Program
    {
        static void Main(string[] args)
        {
            IPerson holder = Factory.CreatePerson();
            holder.FirstName = "Mia";
            holder.LastName = "Terry";
            holder.Email = "mia.terry@gmail.com";
            holder.Phone = "477-2645683";

            IAccount account = Factory.CreateAccount();
            account.AccountNumber = 12345;
            account.AccountHolder = holder;
            account.Balance = 3000M;
            account.TransactionDate = DateTime.Now;

            account.Deposit(1000);
            account.Withdraw(500);

            Console.ReadLine();
        }
    }
}
