using System.Collections.Generic;

namespace InvestmentClasses.Domain
{
    public class Account
    {
        public string AccountNo { get; set; }
        public string Name { get; set; }

        public Institution Institution { get; set; }

        public List<Transaction> Transactions { get; set; } = new List<Transaction>();

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
