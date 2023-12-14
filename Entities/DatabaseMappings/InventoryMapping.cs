using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDatabaseFirst.Entities.DatabaseMappings
{
    public class InventoryMapping:EntityTypeConfiguration<Inventory>
    {
        public InventoryMapping()
        {
            ToTable("Inventory");
            HasKey(i => i.ProductID);

            Property(i => i.ProductName).IsRequired().HasMaxLength(100).HasColumnName("ProductName");
            Property(i => i.ProductAmount).IsRequired().HasColumnName("ProductAmount");
            Property(i => i.RecorderLevel).IsRequired().HasColumnName("RecorderLevel");
            Property(i => i.ProductPrice).IsRequired().HasColumnName("ProductPrice").HasPrecision(18, 2);
        }
    }
}
