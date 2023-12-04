using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDatabaseFirst.Entities
{
    public class Inventory
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int ProductAmount { get; set; }
        public int RecorderLevel { get; set; }
    }
}
