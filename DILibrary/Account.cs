using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DILibrary
{
    public class Account : IAccount
    {
        private readonly ILogger _logger;
        private readonly ISendMessage _sendMessage;

        public int AccountNumber { get; set; }
        public IPerson AccountHolder { get; set; }
        public decimal Balance { get; set; }
        public DateTime TransactionDate { get; set; }

        public Account(ILogger logger, ISendMessage sendMessage)
        {
            _logger = logger;
            _sendMessage = sendMessage;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
            _logger.Log($"You deposit { amount } to account: { AccountNumber }. Now balance is { Balance }.");
            _sendMessage.Send(AccountHolder, $"You deposit { amount } to account: { AccountNumber }. Now balance is { Balance }.");
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount;
            _logger.Log($"You withdraw { amount } from account: { AccountNumber }. Now balance is { Balance }.");
            _sendMessage.Send(AccountHolder, $"You withdraw { amount } from account: { AccountNumber }. Now balance is { Balance }.");
        }
    }
}
