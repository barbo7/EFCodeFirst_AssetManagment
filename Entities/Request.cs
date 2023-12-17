using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDatabaseFirst.Entities
{
    public class Request
    {
        public int RequestID { get; set; }
        public int EmployeeID { get; set; }
        public string RequestType { get; set; }
        public string RequestDetails { get; set; }
        public DateTime RequestDate { get; set; }
        public string RequestStatus { get; set; }
        public int ApprovedBy { get; set;}
        public DateTime ApprovedDate { get; set; }
    }
}
