using System;
using InvestmentClasses.Data;
using InvestmentClasses.Data.InMemoryData;
using InvestmentClasses.Domain;

namespace InvestmentClasses
{
    class Program
    {
        private static DataContext _dataContext = new DataContext();

        static void Main(string[] args)
        {
            IDataLoader loader = new InMemoryDataLoader();
            loader.LoadData(_dataContext);

            PrintTransactionHistroy(_dataContext);
        }

        private static void PrintTransactionHistroy(DataContext dataContext)
        {
            foreach (Transaction transaction in dataContext.Transactions)
            {
                Console.WriteLine(transaction.OwningAccount.Name);
                Console.WriteLine(
                    "ID: " + transaction.TransactionId.ToString() +
                    " | Date: " + transaction.Time.Date.ToString() +
                    " | Amount: " + transaction.Amount.ToString() + 
                    " | Securable: " + transaction.Securable.Name + 
                    " | Description: " + transaction.Description.ToString() + 
                    " | Balance: " + transaction.OwningAccount.Balance(transaction).ToString()
                    );
            }
        }
    }
}
