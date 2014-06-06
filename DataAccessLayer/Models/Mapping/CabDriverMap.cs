using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccessLayer.Models.Mapping
{
    public class CabDriverMap : EntityTypeConfiguration<CabDriver>
    {
        public CabDriverMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.DriverId)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.FirstName)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.LastName)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Address)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.VehicaleNo)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.Paymethod)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.IsAvailable)
                .IsRequired()
                .HasMaxLength(3);

            // Table & Column Mappings
            this.ToTable("CabDriver");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.DriverId).HasColumnName("DriverId");
            this.Property(t => t.FirstName).HasColumnName("FirstName");
            this.Property(t => t.LastName).HasColumnName("LastName");
            this.Property(t => t.ContactNo).HasColumnName("ContactNo");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.VehicleType).HasColumnName("VehicleType");
            this.Property(t => t.VehicaleNo).HasColumnName("VehicaleNo");
            this.Property(t => t.RegisterdDate).HasColumnName("RegisterdDate");
            this.Property(t => t.Paymethod).HasColumnName("Paymethod");
            this.Property(t => t.IsAvailable).HasColumnName("IsAvailable");

            // Relationships
            this.HasRequired(t => t.Vehicle)
                .WithMany(t => t.CabDrivers)
                .HasForeignKey(d => d.VehicleType);

        }
    }
}
