using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using welcamp.Domain.Entities;
using welcamp.Infra.Data.Mapping;

namespace welcamp.Infra.Data.Context
{
    public class DbConnection:DbContext
    {
        public DbSet<User> User { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-1Q2TUU\LEMOSDATABASE;Initial Catalog=DbWelcamp;User ID=sa;Password=@Lemos318");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(new UserMap().Configure);
        }
    }
}
