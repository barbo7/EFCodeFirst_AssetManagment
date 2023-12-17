using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDatabaseFirst.Entities
{
    public class Workflow
    {
        public int WorkflowID { get; set; }
        public string WorkflowName { get; set; }
        public string Description { get; set; }
        public string RelatedDepartment { get; set; }
        public string Steps { get; set; }

        public virtual ICollection<WorkflowStatus> WorkflowStatus { get; set; }
    }
}
