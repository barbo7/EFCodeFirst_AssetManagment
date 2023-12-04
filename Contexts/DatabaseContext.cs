using EFDatabaseFirst.Entities;
using EFDatabaseFirst.Entities.DatabaseMappings;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDatabaseFirst.Contexts
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext():base("name=AssetManagementDBConnectionString")
        {

        }
        public DbSet<Asset> Assets { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<MaintenanceRecord> MaintenanceRecords { get; set; }
        public DbSet<UsageRegistration> UsageRegistrations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AssetMapping());
            modelBuilder.Configurations.Add(new InventoryMapping());
            modelBuilder.Configurations.Add(new EmployeeMapping());
            modelBuilder.Configurations.Add(new MaintenanceRecordMapping());
            modelBuilder.Configurations.Add(new UsageRegistrationMapping());
        }
    }
}
