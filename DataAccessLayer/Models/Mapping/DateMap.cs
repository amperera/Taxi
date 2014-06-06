using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataAccessLayer.Models.Mapping
{
    public class DateMap : EntityTypeConfiguration<Date>
    {
        public DateMap()
        {
            // Primary Key
            this.HasKey(t => t.Date1);

            // Properties
            // Table & Column Mappings
            this.ToTable("Date");
            this.Property(t => t.Date1).HasColumnName("Date");
        }
    }
}
