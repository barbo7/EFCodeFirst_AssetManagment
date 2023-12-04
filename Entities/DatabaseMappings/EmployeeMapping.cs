using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Data.Entity.ModelConfiguration;

namespace EFDatabaseFirst.Entities.DatabaseMappings
{
    public class EmployeeMapping:EntityTypeConfiguration<Employee>
    {
        public EmployeeMapping()
        {
            ToTable("Employees");
            HasKey(e => e.EmployeeID);

            Property(e => e.EmployeeName).IsRequired().HasMaxLength(100).HasColumnName("EmployeeName");
            Property(e => e.EmployeeDepartment).IsRequired().HasMaxLength(100).HasColumnName("EmployeeDepartment");
            Property(e => e.EmployeeRole).IsRequired().HasMaxLength(50).HasColumnName("EmployeeRole");
            Property(e => e.EmployeeDetails).IsRequired().HasMaxLength(200).HasColumnName("EmployeeDetails");
        }
    }
}
