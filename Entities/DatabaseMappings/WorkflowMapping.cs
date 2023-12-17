using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;
using System.Threading.Tasks;

namespace EFDatabaseFirst.Entities.DatabaseMappings
{
    public class WorkflowMapping:EntityTypeConfiguration<Workflow>
    {
        public WorkflowMapping()
        {
            ToTable("Workflows");
            HasKey(w => w.WorkflowID);

            Property(w => w.WorkflowName).IsRequired().HasMaxLength(100).HasColumnName("WorkflowName");
            Property(w => w.Description).IsRequired().HasMaxLength(255).HasColumnName("Description");
            Property(w => w.RelatedDepartment).IsRequired().HasMaxLength(100).HasColumnName("RelatedDepartment");
            Property(w => w.Steps).IsRequired().HasColumnName("Steps");
        }
    }   
}
