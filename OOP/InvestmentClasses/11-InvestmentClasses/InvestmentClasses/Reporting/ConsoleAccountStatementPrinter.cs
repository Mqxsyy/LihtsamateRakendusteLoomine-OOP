using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentClasses.Reporting
{
    public class ConsoleAccountStatementPrinter : IAccountStatementPrinter
    {
        private readonly AccountStatement _statement;

        public ConsoleAccountStatementPrinter(AccountStatement statement)
        {
            _statement = statement;
        }
        public void Print()
        {
            PrintAccStatementBuilderHeader(_statement.Header);
            PrintAccStatementBuilderEntries(_statement.Entries);
        }

        private static void PrintAccStatementBuilderHeader(AccountStatementHeader header)
        {
            Console.WriteLine(
                "No: " + header.AccountNo.ToString() +
                " | Name: " + header.AccountName.ToString() +
                " | From: " + header.FromDate.ToString() +
                " | To: " + header.ToDate.ToString() +
                " | Starting balance: " + header.StartingBalance.ToString()
                );
        }

        private static void PrintAccStatementBuilderEntries(IList<AccountStatementEntry> entires)
        {
            foreach (AccountStatementEntry entry in entires)
            {
                Console.WriteLine(
                    "ID: " + entry.TransactionId.ToString() +
                    " | Time: " + entry.Time.ToString() +
                    " | Amount: " + entry.Amount.ToString() +
                    " | Balance: " + entry.Balance.ToString() +
                    " | Securable: " + entry.Securable.ToString() +
                    " | Description: " + entry.Description.ToString() +
                    " | Other account: " + entry.OtherAccount.ToString()
                    );
            }
        }
    }
}
