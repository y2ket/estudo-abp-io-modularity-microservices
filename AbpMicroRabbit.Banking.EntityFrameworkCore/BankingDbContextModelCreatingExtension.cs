﻿using AbpMicroRabbit.Banking.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace AbpMicroRabbit.Banking.EntityFrameworkCore
{
    public static class BankingDbContextModelCreatingExtension
    {
        public static void ConfigureBankingDb(this ModelBuilder builder)
        {
            builder.Entity<Account>(b =>
            {
                b.ToTable("Accounts");
                b.ConfigureExtraProperties();
            });
        }

        public static void SeedBankingDb(this ModelBuilder builder)
        {
            builder.Entity<Account>(b =>
            {
                b.HasData(new Account("Poupança", 100),
                          new Account("Credito", 200));
            });
        }
    }
}
