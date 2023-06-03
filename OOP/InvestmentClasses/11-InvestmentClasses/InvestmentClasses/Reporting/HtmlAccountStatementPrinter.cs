using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentClasses.Reporting
{
    public class HtmlAccountStatementPrinter : IAccountStatementPrinter
    {
        private readonly AccountStatement _statement;
        private readonly string _fileName;

        public HtmlAccountStatementPrinter(AccountStatement statement, string fileName)
        {
            _statement = statement;
            _fileName = fileName;
        }

        public void Print()
        {
            if(File.Exists(_fileName))
            {
                File.Delete(_fileName);
            }

            // Kasuta File.AppendAllText(), et kirjutada HTML välja
            File.AppendAllText(_fileName, "<html>");

            string appendHeaderText = "<p><span style=\"font-size:24px\"><strong>" + "No: " + _statement.Header.AccountNo.ToString() +
                " | Name: " + _statement.Header.AccountName.ToString() +
                " | From: " + _statement.Header.FromDate.ToString() +
                " | To: " + _statement.Header.ToDate.ToString() +
                " | Starting balance: " + _statement.Header.StartingBalance.ToString() + "</strong></span></p>";

            File.AppendAllText(_fileName, appendHeaderText);

            foreach (AccountStatementEntry entry in _statement.Entries)
            {
                string appendEntryText = "<p>" +
                    "ID: " + entry.TransactionId.ToString() +
                    " | Time: " + entry.Time.ToString() +
                    " | Amount: " + entry.Amount.ToString() +
                    " | Balance: " + entry.Balance.ToString() +
                    " | Securable: " + entry.Securable.ToString() +
                    " | Description: " + entry.Description.ToString() +
                    " | Other account: " + entry.OtherAccount.ToString() + "</p>";

                File.AppendAllText(_fileName, appendEntryText);
            }

            File.AppendAllText(_fileName, "</html>");
        }
    }
}
