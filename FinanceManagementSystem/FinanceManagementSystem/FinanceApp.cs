using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceManagementSystem
{ 
    public class FinanceApp
    {
        private List<Transaction> _transactions;

        public void Run()
        {
            // sample transactions
            var savingsAccount = new SavingsAccount("1234567890", 1000.00m);

            // tansactions
            var transaction1 = new Transaction
            {
                Id = 1,
                DateTime = DateTime.Now,
                Amount = 100.00m,
                Category = "Groceries"
            };
            var transaction2 = new Transaction
            {
                Id = 2,
                DateTime = DateTime.Now,
                Amount = 50.00m,
                Category = "Utilities"
            };
            var transaction3 = new Transaction
            {
                Id = 3,
                DateTime = DateTime.Now,
                Amount = 200.00m,
                Category = "Entertainment"
            };

            // Process transactions
            ITransactionProcessor mobileMoneyProcessor = new MobileMoneyProcessor();
            ITransactionProcessor bankTransferProcessor = new BankTransferProcessor();
            ITransactionProcessor cryptoWalletProcessor = new CryptoWalletProcessor();

            mobileMoneyProcessor.Process(transaction1);
            bankTransferProcessor.Process(transaction2);    
            cryptoWalletProcessor.Process(transaction3);

            // Add transactions to the savings account
            savingsAccount.ApplyTransaction(transaction1);
            savingsAccount.ApplyTransaction(transaction2);
            savingsAccount.ApplyTransaction(transaction3);

            // Add transactions to the _transactions list
            _transactions.Add(transaction1);
            _transactions.Add(transaction2);
            _transactions.Add(transaction3);

        }
    }
}
