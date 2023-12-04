using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDatabaseFirst.Entities.DatabaseMappings
{
    public class MaintenanceRecordMapping:EntityTypeConfiguration<MaintenanceRecord>
    {
        public MaintenanceRecordMapping()
        {
            ToTable("MaintenanceRecords");
            HasKey(m => m.MaintenanceRecordID);

            Property(m => m.MaintenanceDate).IsRequired().HasColumnName("MaintenanceDate");
            Property(m => m.MaintenanceDetails).IsRequired().HasColumnName("MaintenanceDetails");
            Property(m => m.MaintenanceCost).IsRequired().HasColumnName("MaintenanceCost").HasPrecision(18,2);
        }
    }
}
