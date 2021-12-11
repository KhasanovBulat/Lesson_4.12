using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter13
{
    class BankTransaction
    {
        public DateTime TransactionTime { get; }
        public decimal sum { get; }
        public TransactionType transactionType { get; set; }

        internal BankTransaction(TransactionType transactionType, DateTime TransactionTime, decimal sum)
        {
            this.transactionType = transactionType;
            this.TransactionTime = TransactionTime;
            this.sum = sum;

        }
    }
}
