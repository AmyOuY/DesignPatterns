using ISPLibrary.CheckingAccounts;
using ISPLibrary.GeneralInterfaces;
using ISPLibrary.SavingAccounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    class Program
    {
        static void Main(string[] args)
        {
            IFlexibleSavingAccount sa = new FlexibleSavingAccount();
            sa.Deposit(300);
            Console.WriteLine($"Deposit 300 into flexible saving account: { sa.AccountNumber } on date { sa.TransactionDate }. Balance is: { sa.Balance }");
            sa.Withdraw(100);
            Console.WriteLine($"Withdraw 100 from flexible saving account: { sa.AccountNumber } on date { sa.TransactionDate }. Balance is: { sa.Balance }");

            IFixedTermSavingAccount fixedSa = new FixedTermSavingAccount();
            Console.WriteLine($"Balance of fixed term saving account: { fixedSa.AccountNumber } is: { fixedSa.Balance }");

            ICheckingAccount ca = new CheckingAccount();
            ca.Deposit(200);
            Console.WriteLine($"Deposit 200 into checking account: { ca.AccountNumber } on date { ca.TransactionDate }. Balance is: { ca.Balance }");
            ca.Withdraw(400);
            Console.WriteLine($"Withdraw 400 from checking account: { ca.AccountNumber } on date { ca.TransactionDate }. Balance is: { ca.Balance }");

            Console.ReadLine();
        }
    }
}
