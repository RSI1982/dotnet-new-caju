﻿namespace MyProject.Infrastructure.DataAccess
{
    using MyProject.Application.Repositories;
    using MongoDB.Driver;
    using System;
    using System.Threading.Tasks;
    using MyProject.Domain.Accounts;

    public class AccountRepository : IAccountReadOnlyRepository, IAccountWriteOnlyRepository
    {
        private readonly AccountBalanceContext mongoContext;

        public AccountRepository(AccountBalanceContext mongoContext)
        {
            this.mongoContext = mongoContext;
        }

        public async Task Add(Account account)
        {
            await mongoContext.Accounts.InsertOneAsync(account);
        }

        public async Task Delete(Account account)
        {
            await mongoContext.Accounts.DeleteOneAsync(e => e.Id == account.Id);
        }

        public async Task<Account> Get(Guid id)
        {
            return await mongoContext
                .Accounts
                .Find(e => e.Id == id)
                .SingleOrDefaultAsync();
        }

        public async Task Update(Account account)
        {
            await mongoContext.Accounts.ReplaceOneAsync(e => e.Id == account.Id, account);
        }
    }
}
