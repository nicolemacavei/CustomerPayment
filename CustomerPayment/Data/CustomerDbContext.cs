using CustomerPayment.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace CustomerPayment.Data
{
    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext(DbContextOptions<CustomerDbContext> options)
            :base(options)
        { 
        }

        public DbSet<Customers> Customers { get; set; }

        public DbSet<Articles> Articles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Articles>().HasData(
                new Articles
                {
                    Id = 1,
                    Description = (string)"description",
                    Title = (string)"title"
                });
        }

        public DbSet<Payments> Payments { get; set; }

        public DbSet<Transactions> Transactions { get; set; }

        public DbSet<ArticleTransaction>  ArticleTransactions { get; set; }

    }
}
