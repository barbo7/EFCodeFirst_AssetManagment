using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDatabaseFirst.Entities
{
    public class MaintenanceRecord
    {
        public int MaintenanceRecordID { get; set; }
        public int AssetID { get; set; }
        public DateTime MaintenanceDate { get; set; }
        public string MaintenanceDetails { get; set; }
        public decimal MaintenanceCost { get; set; }
    }
}
