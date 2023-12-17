using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace EFDatabaseFirst.Entities.DatabaseMappings
{
    public class WorkflowStatusMapping:EntityTypeConfiguration<WorkflowStatus>
    {
        public WorkflowStatusMapping()
        {
            ToTable("WorkflowStatus");
            HasKey(w => w.WorkflowStatusID);

            Property(w => w.WorkFlowID).IsRequired().HasColumnName("WorkFlowID");
            Property(w => w.Step).IsRequired().HasMaxLength(100).HasColumnName("Step");
            Property(w => w.Status).IsRequired().HasMaxLength(100).HasColumnName("Status");
            Property(w => w.AssignedTo).IsOptional().HasMaxLength(100).HasColumnName("AssignedTo");
            Property(w => w.StartDate).IsOptional().HasColumnName("StartDate");
            Property(w => w.CompletedDate).IsOptional().HasColumnName("CompletedDate");

            // WorkflowStatusMapping sınıfınızın içinde
            HasRequired(w => w.Workflow)
                .WithMany(wf => wf.WorkflowStatus)
                .HasForeignKey(w => w.WorkFlowID);
        }
    }
}
