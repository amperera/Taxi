using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccessLayer.Models.Mapping
{
    public class VehicleMap : EntityTypeConfiguration<Vehicle>
    {
        public VehicleMap()
        {
            // Primary Key
            this.HasKey(t => t.VId);

            // Properties
            this.Property(t => t.Type)
                .IsRequired()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("Vehicle");
            this.Property(t => t.VId).HasColumnName("VId");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.DepositAmount).HasColumnName("DepositAmount");
            this.Property(t => t.PerKM).HasColumnName("PerKM");
        }
    }
}
