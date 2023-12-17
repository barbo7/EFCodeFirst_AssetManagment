using EFDatabaseFirst.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDatabaseFirst
{
    public class WorkflowStatus
    {
        public int WorkflowStatusID { get; set; }
        public int WorkFlowID { get; set; }
        public string Step { get; set; }
        public string AssignedTo { get; set; }
        public string Status { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime CompletedDate { get; set; }


        // Navigasyon Özelliği
        public virtual Workflow Workflow { get; set; }
    }
}
