using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvestmentClasses.Domain;

namespace InvestmentClasses.Reporting
{
    public class AccountStatementBuilder
    {
        private readonly Account _account;

        public AccountStatementBuilder(Account account)
        {
            _account = account;
        }

        public AccountStatement Build(DateTime fromDate, DateTime toDate)
        {
            var statement = new AccountStatement();

            BuildHeader(statement.Header, fromDate, toDate);
            BuildEntries(statement, fromDate, toDate);

            return statement;
        }

        private void BuildHeader(AccountStatementHeader header, DateTime fromDate, DateTime toDate)
        {
            header.AccountName = _account.Name;
            header.AccountNo = _account.AccountNo;
            header.FromDate = fromDate;
            header.ToDate = toDate;
            header.StartingBalance = _account.Balance(fromDate);
        }

        // Kannete osa (transactionite põhjal AccountStatementEntry´)
        private void BuildEntries(AccountStatement statement, DateTime fromDate, DateTime toDate)
        {
            foreach (Transaction transaction in _account.Transactions)
            {
                if (transaction.Time < fromDate) continue;
                if (transaction.Time > toDate) continue;

                AccountStatementEntry entry = new AccountStatementEntry();
                entry.TransactionId = transaction.TransactionId;
                entry.Time = transaction.Time;
                entry.Amount = transaction.Amount;
                entry.Balance = _account.Balance(transaction);
                entry.Securable = transaction.Securable.Name;
                entry.Description = transaction.Description;

                if (transaction.OtherAccount != null)
                    entry.OtherAccount = transaction.OtherAccount.ToString();
                else 
                    entry.OtherAccount = "";

                statement.Entries.Add(entry);
            }
        }
    }
}
