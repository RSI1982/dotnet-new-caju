﻿namespace MyProject.Domain.Accounts
{
    using MyProject.Domain.ValueObjects;
    using System;

    public abstract class Transaction : Entity
    {
        public Amount Amount { get; private set; }
        public abstract string Description { get; }
        public DateTime TransactionDate { get; private set; }

        public Transaction(Amount amount)
        {
            TransactionDate = DateTime.Now;
            Amount = amount;
        }

        public Transaction(Amount amount, DateTime transactionDate)
            : this(amount)
        {
            TransactionDate = transactionDate;
        }
    }
}
