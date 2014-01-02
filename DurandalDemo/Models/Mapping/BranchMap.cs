using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DurandalDemo.Models.Mapping
{
    public class BranchMap : EntityTypeConfiguration<Branch>
    {
        public BranchMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            // Table & Column Mappings
            this.ToTable("Branches");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Address_AddressLine1).HasColumnName("Address_AddressLine1");
            this.Property(t => t.Address_AddressLine2).HasColumnName("Address_AddressLine2");
            this.Property(t => t.Address_City).HasColumnName("Address_City");
            this.Property(t => t.Address_State).HasColumnName("Address_State");
            this.Property(t => t.Address_Zip).HasColumnName("Address_Zip");
        }
    }
}
