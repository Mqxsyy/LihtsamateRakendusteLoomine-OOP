using System;
using System.Linq;
using InvestmentClasses.Domain;

namespace InvestmentClasses.Data.InMemoryData
{
    public static class TransactionsLoader
    {
        public static void LoadTransactions(DataContext context)
        {
            Pohikonto20230401(context); // Põhikonto rahade liikumine 01.04.2023
        }

        private static void Pohikonto20230401(DataContext context)
        {
            var swed = context.Accounts.GetByName("Põhikonto");
            var eur = context.Securables.GetByTicker("EUR");

            // 1
            context.Transactions.Add(new Transaction
            {
                TransactionId = "",
                OwningAccount = swed,
                OtherAccount = null,
                Time = DateTime.Parse("2023-04-01 10:00:00"),
                Amount = 1000m,
                Securable = eur,
                Description = "Palk 2023-03"
            });

            // 2
            context.Transactions.Add(new Transaction
            {
                TransactionId = "",
                OwningAccount = swed,
                OtherAccount = null,
                Time = DateTime.Parse("2023-04-01 11:00:00"),
                Amount = -20m,
                Securable = eur,
                Description = "PRISMA POS/XSD/9393873/9392" // Kommid
            });

            // 3
            context.Transactions.Add(new Transaction
            {
                TransactionId = "",
                OwningAccount = swed,
                OtherAccount = null,
                Time = DateTime.Parse("2023-04-01 11:20:00"),
                Amount = -5m,
                Securable = eur,
                Description = "Ülekanne sõbrale" // Raha sõbrale
            });

            // 4
            context.Transactions.Add(new Transaction
            {
                TransactionId = "",
                OwningAccount = swed,
                OtherAccount = null,
                Time = DateTime.Parse("2023-04-01 11:22:00"),
                Amount = -15m,
                Securable = eur,
                Description = "Arve B837378992/353535" // Telefoniarve
            });

            // 5
            context.Transactions.Add(new Transaction
            {
                TransactionId = "",
                OwningAccount = swed,
                OtherAccount = null,
                Time = DateTime.Parse("2023-04-01 14:00:00"),
                Amount = -0.5m,
                Securable = eur,
                Description = "Konto hooldustasu"
            });

            // 6
            context.Transactions.Add(new Transaction
            {
                TransactionId = "",
                OwningAccount = swed,
                OtherAccount = null,
                Time = DateTime.Parse("2023-04-06 12:05:00"),
                Amount = 500m,
                Securable = eur,
                Description = "Laenu tagastus sõbralt"
            });

            // 7
            context.Transactions.Add(new Transaction
            {
                TransactionId = "",
                OwningAccount = swed,
                OtherAccount = null,
                Time = DateTime.Parse("2023-04-09 19:02:00"),
                Amount = -100m,
                Securable = eur,
                Description = "Uus hiir"
            });

            // 8
            context.Transactions.Add(new Transaction
            {
                TransactionId = "",
                OwningAccount = swed,
                OtherAccount = null,
                Time = DateTime.Parse("2023-04-10 11:39:00"),
                Amount = -30m,
                Securable = eur,
                Description = "Rimi ostud"
            });

            // 9
            context.Transactions.Add(new Transaction
            {
                TransactionId = "",
                OwningAccount = swed,
                OtherAccount = null,
                Time = DateTime.Parse("2023-04-10 18:15:00"),
                Amount = -75m,
                Securable = eur,
                Description = "Unity asset library purchase"
            });

            // 10
            context.Transactions.Add(new Transaction
            {
                TransactionId = "",
                OwningAccount = swed,
                OtherAccount = null,
                Time = DateTime.Parse("2023-04-12 07:35:00"),
                Amount = -3.5m,
                Securable = eur,
                Description = "Rongipilet"
            });

            // 11
            context.Transactions.Add(new Transaction
            {
                TransactionId = "",
                OwningAccount = swed,
                OtherAccount = null,
                Time = DateTime.Parse("2023-04-12 9:30:00"),
                Amount = -15m,
                Securable = eur,
                Description = "Kohviku ostud"
            });

            // 12
            context.Transactions.Add(new Transaction
            {
                TransactionId = "",
                OwningAccount = swed,
                OtherAccount = null,
                Time = DateTime.Parse("2023-04-20 15:00:00"),
                Amount = 500m,
                Securable = eur,
                Description = "Müüdud teenuse tasu"
            });

            // 13
            context.Transactions.Add(new Transaction
            {
                TransactionId = "",
                OwningAccount = swed,
                OtherAccount = null,
                Time = DateTime.Parse("2023-04-23 19:05:00"),
                Amount = -2m,
                Securable = eur,
                Description = "Filmilaenutus"
            });

            // 14
            context.Transactions.Add(new Transaction
            {
                TransactionId = "",
                OwningAccount = swed,
                OtherAccount = null,
                Time = DateTime.Parse("2023-04-24 12:41:00"),
                Amount = -30m,
                Securable = eur,
                Description = "Raamatud Apollost"
            });

            // 15
            context.Transactions.Add(new Transaction
            {
                TransactionId = "",
                OwningAccount = swed,
                OtherAccount = null,
                Time = DateTime.Parse("2023-04-24 13:34:00"),
                Amount = -10m,
                Securable = eur,
                Description = "Kink emale"
            });

            // 16
            context.Transactions.Add(new Transaction
            {
                TransactionId = "",
                OwningAccount = swed,
                OtherAccount = null,
                Time = DateTime.Parse("2023-05-01 12:00:00"),
                Amount = 1000m,
                Securable = eur,
                Description = "Palk"
            });

            // 17
            context.Transactions.Add(new Transaction
            {
                TransactionId = "",
                OwningAccount = swed,
                OtherAccount = null,
                Time = DateTime.Parse("2023-05-03 16:30:00"),
                Amount = -400m,
                Securable = eur,
                Description = "Auto hooldustasu"
            });

            // 18
            context.Transactions.Add(new Transaction
            {
                TransactionId = "",
                OwningAccount = swed,
                OtherAccount = null,
                Time = DateTime.Parse("2023-05-06 13:39:00"),
                Amount = -100m,
                Securable = eur,
                Description = "Elektriarved"
            });

            // 19
            context.Transactions.Add(new Transaction
            {
                TransactionId = "",
                OwningAccount = swed,
                OtherAccount = null,
                Time = DateTime.Parse("2023-05-07 16:15:00"),
                Amount = 125m,
                Securable = eur,
                Description = "Teenuse müük"
            });

            // 20
            context.Transactions.Add(new Transaction
            {
                TransactionId = "",
                OwningAccount = swed,
                OtherAccount = null,
                Time = DateTime.Parse("2023-05-09 12:11:00"),
                Amount = -205m,
                Securable = eur,
                Description = "Uued riided"
            });

            swed.Transactions.AddRange(context.Transactions.Where(t => t.OwningAccount == swed));
        }
    }
}
