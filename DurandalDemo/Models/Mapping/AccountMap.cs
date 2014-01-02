using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalDemo.Models.Mapping
{
    public class AccountMap : EntityTypeConfiguration<Account>
    {
        public AccountMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Discriminator)
                .IsRequired()
                .HasMaxLength(128);

            // Table & Column Mappings
            this.ToTable("Accounts");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Balance).HasColumnName("Balance");
            this.Property(t => t.AccountNumber).HasColumnName("AccountNumber");
            this.Property(t => t.APY).HasColumnName("APY");
            this.Property(t => t.RoutingNumber).HasColumnName("RoutingNumber");
            this.Property(t => t.APR).HasColumnName("APR");
            this.Property(t => t.Term).HasColumnName("Term");
            this.Property(t => t.Discriminator).HasColumnName("Discriminator");
            this.Property(t => t.AccountHolder_Id).HasColumnName("AccountHolder_Id");

            // Relationships
            this.HasOptional(t => t.Customer)
                .WithMany(t => t.Accounts)
                .HasForeignKey(d => d.AccountHolder_Id);

        }
    }
}
