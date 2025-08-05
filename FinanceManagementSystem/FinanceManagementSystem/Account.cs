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

    // Saving accout (sealed) class
    public sealed class  SavingsAccount : Account
    {
        public SavingsAccount(string accountNumber, decimal initialBalance) : base(accountNumber, initialBalance)
        {
        }

        public override void ApplyTransaction(Transaction transaction)
        {
            if (transaction.Amount > Balance)
                Console.WriteLine("Insuffiecient Balance.");
            else
                Balance -= transaction.Amount;
            Console.WriteLine($"Transaction successful. New balance: {Balance}");
        }
    }

}
