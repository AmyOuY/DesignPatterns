using System;

namespace DILibrary
{
    public interface IAccount
    {
        IPerson AccountHolder { get; set; }
        int AccountNumber { get; set; }
        decimal Balance { get; set; }
        DateTime TransactionDate { get; set; }

        void Deposit(decimal amount);
        void Withdraw(decimal amount);
    }
}