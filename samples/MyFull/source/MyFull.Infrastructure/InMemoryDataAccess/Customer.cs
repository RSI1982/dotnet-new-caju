namespace MyFull.Infrastructure.InMemoryDataAccess
{
    using System;
    using System.Collections.Generic;
    using MyFull.Domain.Customers;
    using MyFull.Domain.ValueObjects;

    public class Customer : MyFull.Domain.Customers.Customer
    {
        public Customer() { }

        public Customer(SSN ssn, Name name)
        {
            Id = Guid.NewGuid();
            SSN = ssn;
            Name = name;
        }

        public void LoadAccounts(IEnumerable<Guid> accounts)
        {
            Accounts = new AccountCollection();
            Accounts.Add(accounts);
        }
    }
}