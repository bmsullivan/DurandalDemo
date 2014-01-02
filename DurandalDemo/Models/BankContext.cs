using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using DurandalDemo.Models.Mapping;

namespace DurandalDemo.Models
{
    public partial class BankContext : DbContext
    {
        static BankContext()
        {
            Database.SetInitializer<BankContext>(null);
        }

        public BankContext()
            : base("Name=BankContext")
        {
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AccountMap());
            modelBuilder.Configurations.Add(new BranchMap());
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new TransactionMap());
        }
    }
}
