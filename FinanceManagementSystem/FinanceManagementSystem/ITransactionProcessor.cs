using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceManagementSystem
{
    public interface ITransactionProcessor
    {
        void Process(Transaction transaction);
    }

    public class BankTransferProcessor : ITransactionProcessor
    {
        public void Process(Transaction transaction)
        {
            // Logic to process bank transfer transactions
            Console.WriteLine($"Processed bank transfer of GHS {transaction.Amount:F2} for {transaction.Category}");
        }
    }

    public class MobileMoneyProcessor : ITransactionProcessor
    {
        public void Process(Transaction transaction)
        {
            Console.WriteLine($"Processed mobile money transaction of GHS {transaction.Amount:F2} for {transaction.Category}");
        }

    }

    public class CryptoWalletProcessor : ITransactionProcessor
    {
        public void Process(Transaction transaction)
        {
            Console.WriteLine($"Processed cryptocurrency transaction of GHS {transaction.Amount:F2} for {transaction.Category}");
        }

    }
}
