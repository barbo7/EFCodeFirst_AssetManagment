using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDatabaseFirst.Entities
{
    public class UsageRegistration
    {
        public int UsageRegistrationID { get; set; }
        public int AssetID { get; set; }
        public int PersonelID { get; set; }
        public DateTime UsageDateStart { get; set; }
        public DateTime UsageDateEnd{ get; set; }
        public string UsageRegistrationStatus{ get; set; }
    }
}
