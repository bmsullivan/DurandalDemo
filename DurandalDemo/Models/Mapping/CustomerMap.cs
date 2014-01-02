using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalDemo.Models.Mapping
{
    public class CustomerMap : EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("Customers");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.HomeAddress_AddressLine1).HasColumnName("HomeAddress_AddressLine1");
            this.Property(t => t.HomeAddress_AddressLine2).HasColumnName("HomeAddress_AddressLine2");
            this.Property(t => t.HomeAddress_City).HasColumnName("HomeAddress_City");
            this.Property(t => t.HomeAddress_State).HasColumnName("HomeAddress_State");
            this.Property(t => t.HomeAddress_Zip).HasColumnName("HomeAddress_Zip");
            this.Property(t => t.PhoneNumber).HasColumnName("PhoneNumber");
            this.Property(t => t.HomeBranch_Id).HasColumnName("HomeBranch_Id");

            // Relationships
            this.HasOptional(t => t.Branch)
                .WithMany(t => t.Customers)
                .HasForeignKey(d => d.HomeBranch_Id);

        }
    }
}
