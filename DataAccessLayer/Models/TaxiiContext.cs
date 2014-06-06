using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using DataAccessLayer.Models.Mapping;

namespace DataAccessLayer.Models
{
    public partial class TaxiiContext : DbContext
    {
        static TaxiiContext()
        {
            Database.SetInitializer<TaxiiContext>(null);
        }

        public TaxiiContext()
            : base("Name=TaxiiContext")
        {
        }

        public DbSet<CabDriver> CabDrivers { get; set; }
        public DbSet<Date> Dates { get; set; }
        public DbSet<PickUp> PickUps { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleCt> VehicleCts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CabDriverMap());
            modelBuilder.Configurations.Add(new DateMap());
            modelBuilder.Configurations.Add(new PickUpMap());
            modelBuilder.Configurations.Add(new VehicleMap());
            modelBuilder.Configurations.Add(new VehicleCtMap());
        }
    }
}
