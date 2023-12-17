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
        public DbSet<Request> Requesties { get; set; }
        public DbSet<Workflow> Workflows { get; set; }
        public DbSet<WorkflowStatus> WorkflowStatus { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AssetMapping());
            modelBuilder.Configurations.Add(new InventoryMapping());
            modelBuilder.Configurations.Add(new EmployeeMapping());
            modelBuilder.Configurations.Add(new MaintenanceRecordMapping());
            modelBuilder.Configurations.Add(new UsageRegistrationMapping());
            modelBuilder.Configurations.Add(new RequestMapping());
            modelBuilder.Configurations.Add(new WorkflowMapping());
            modelBuilder.Configurations.Add(new WorkflowStatusMapping());
        }
    }
}
