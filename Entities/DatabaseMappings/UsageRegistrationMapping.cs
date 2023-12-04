using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDatabaseFirst.Entities.DatabaseMappings
{
    public class UsageRegistrationMapping:EntityTypeConfiguration<UsageRegistration>
    {
        public UsageRegistrationMapping()
        {
            ToTable("UsageRegistrations");
            HasKey(u => u.UsageRegistrationID);

            Property(u => u.AssetID).IsRequired().HasColumnName("AssetID");
            Property(u => u.PersonelID).IsRequired().HasColumnName("PersonelID");
            Property(u => u.UsageDateStart).IsRequired().HasColumnName("UsageDateStart");
            Property(u => u.UsageDateEnd).IsRequired().HasColumnName("UsageDateEnd");
            Property(u => u.UsageRegistrationStatus).IsRequired().HasMaxLength(50).HasColumnName("UsageRegistrationStatus");
        }
    }
}
