using System;
using InvestmentClasses.Data;
using InvestmentClasses.Data.InMemoryData;
using InvestmentClasses.Reporting;

namespace InvestmentClasses
{
    class Program
    {
        private static DataContext _dataContext = new DataContext();

        static void Main(string[] args)
        {
            IDataLoader loader = new InMemoryDataLoader();
            loader.LoadData(_dataContext);

            var account = _dataContext.Accounts.GetByName("Põhikonto"); // Note: Changed to "Põhikonto" since no account with the name of "LHV" exists
            var builder = new AccountStatementBuilder(account);
            var statement = builder.Build(DateTime.Now.Date.AddDays(-90), DateTime.Now.Date);

            IAccountStatementPrinter printer;

            printer = new HtmlAccountStatementPrinter(statement, "statement.html");
            printer.Print();

            printer = new ConsoleAccountStatementPrinter(statement);
            printer.Print();
        }
    }
}
