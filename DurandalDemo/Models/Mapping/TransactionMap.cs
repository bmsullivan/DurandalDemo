using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalDemo.Models.Mapping
{
    public class TransactionMap : EntityTypeConfiguration<Transaction>
    {
        public TransactionMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("Transactions");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.CreatedAt).HasColumnName("CreatedAt");
            this.Property(t => t.Account_Id).HasColumnName("Account_Id");

            // Relationships
            this.HasOptional(t => t.Account)
                .WithMany(t => t.Transactions)
                .HasForeignKey(d => d.Account_Id);

        }
    }
}
