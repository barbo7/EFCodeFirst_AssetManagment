using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using System.Threading.Tasks;

namespace EFDatabaseFirst.Entities.DatabaseMappings
{
    public class RequestMapping:EntityTypeConfiguration<Request>
    {
        public RequestMapping()
        {
            ToTable("Requests");
            HasKey(r => r.RequestID);

            Property(r => r.EmployeeID).IsRequired().HasColumnName("EmployeeID");
            Property(r => r.RequestType).IsRequired().HasMaxLength(100).HasColumnName("RequestType");
            Property(r => r.RequestDetails).IsRequired().HasMaxLength(255).HasColumnName("RequestDetails");
            Property(r => r.RequestDate).IsRequired().HasColumnName("RequestDate");
            Property(r => r.RequestStatus).IsRequired().HasMaxLength(100).HasColumnName("RequestStatus");
            Property(r => r.ApprovedBy).IsOptional().HasColumnName("ApprovedBy");
            Property(r => r.ApprovedDate).IsOptional().HasColumnName("ApprovedDate");
        }
    }
}
