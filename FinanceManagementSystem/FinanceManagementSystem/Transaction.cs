using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceManagementSystem
{
    public class Transaction
    {
        public int Id;
        public DateTime Date { get; init; }
        public decimal Amount { get; init; }
        public string Category { get; init; }
    }
}
