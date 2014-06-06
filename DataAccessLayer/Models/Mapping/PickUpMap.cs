using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccessLayer.Models.Mapping
{
    public class PickUpMap : EntityTypeConfiguration<PickUp>
    {
        public PickUpMap()
        {
            // Primary Key
            this.HasKey(t => t.JNO);

            // Properties
            this.Property(t => t.CustomerName)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.BeginFrom)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Destination)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Note)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("PickUp");
            this.Property(t => t.JNO).HasColumnName("JNO");
            this.Property(t => t.CustomerName).HasColumnName("CustomerName");
            this.Property(t => t.ContactNumber).HasColumnName("ContactNumber");
            this.Property(t => t.BeginFrom).HasColumnName("BeginFrom");
            this.Property(t => t.Destination).HasColumnName("Destination");
            this.Property(t => t.VehicleTypeID).HasColumnName("VehicleTypeID");
            this.Property(t => t.Date).HasColumnName("Date");
            this.Property(t => t.Note).HasColumnName("Note");
            this.Property(t => t.DriverId).HasColumnName("DriverId");

            // Relationships
            this.HasRequired(t => t.CabDriver)
                .WithMany(t => t.PickUps)
                .HasForeignKey(d => d.DriverId);
            this.HasRequired(t => t.Vehicle)
                .WithMany(t => t.PickUps)
                .HasForeignKey(d => d.VehicleTypeID);

        }
    }
}
