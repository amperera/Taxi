using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccessLayer.Models.Mapping
{
    public class VehicleCtMap : EntityTypeConfiguration<VehicleCt>
    {
        public VehicleCtMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.VehicleCategory)
                .IsRequired()
                .HasMaxLength(15);

            // Table & Column Mappings
            this.ToTable("VehicleCt");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.VehicleCategory).HasColumnName("VehicleCategory");
        }
    }
}
