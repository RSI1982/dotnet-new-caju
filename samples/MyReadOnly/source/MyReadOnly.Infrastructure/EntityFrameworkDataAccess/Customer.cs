namespace MyReadOnly.Infrastructure.EntityFrameworkDataAccess
{
    using System;
    using System.Collections.Generic;
    using MyReadOnly.Domain.Customers;
    using MyReadOnly.Domain.ValueObjects;

    public class Customer : MyReadOnly.Domain.Customers.Customer
    {
        protected Customer() { }

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