using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDatabaseFirst.Entities.DatabaseMappings
{
    public class AssetMapping:EntityTypeConfiguration<Asset>
    {
        public AssetMapping()
        {
            ToTable("Assets");
            HasKey(a => a.AssetID);

            Property(a => a.AssetName).IsRequired().HasMaxLength(100).HasColumnName("AssetName");
            Property(a => a.AssetBoughtDate).IsRequired().HasColumnName("AssetBoughtDate");
            Property(a => a.AssetPrice).IsRequired().HasColumnName("AssetPrice").HasPrecision(18,2);
            Property(a => a.AssetStatus).IsRequired().HasMaxLength(50).HasColumnName("AssetStatus");
            Property(a => a.AssetLocation).IsRequired().HasMaxLength(100).HasColumnName("AssetLocation");
        }
    }
}
