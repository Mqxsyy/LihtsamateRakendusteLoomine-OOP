using System;
using System.Collections.Generic;

namespace InvestmentClasses.Domain
{
    public class Account
    {
        public string AccountNo { get; set; }
        public string Name { get; set; }

        public Institution Institution { get; set; }

        public List<Transaction> Transactions { get; set; } = new List<Transaction>();

        public decimal Balance(DateTime fromDate)
        {
            if (Transactions.Count == 0) return 0;
            if (Transactions[0].Time > fromDate) return 0;
            
            for (int i = 0; i < Transactions.Count; i++)
            {
                if (i + 1 >= Transactions.Count)
                    return Balance(Transactions[i]);

                if (Transactions[i].Time <= fromDate && Transactions[i + 1].Time > fromDate)
                    return Balance(Transactions[i]);
            }

            return 0;
        }

        public decimal Balance(Transaction transaction)
        {
            decimal _balance = 0;

            for (int i = 0; i < Transactions.Count; i++)
            {
                _balance += Transactions[i].Amount;
                if (Transactions[i] == transaction) break;
            }

            return _balance;
        }
    }
}
