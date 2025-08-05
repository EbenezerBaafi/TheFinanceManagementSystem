using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceManagementSystem
{
    public class Account
    {
        public string AccountNumber { get; init; }
        public decimal Balance { get; protected set; }

        public Account(string accountNumber, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }

        public virtual void ApplyTransaction(Transaction transaction)
        {
            // Default implementation can be overridden by derived classes
            Balance -= transaction.Amount;
            Console.WriteLine($"Transaction has been applied: {transaction.Amount} to account {AccountNumber}. New balance: {Balance}");
        }
    }

}
