using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDatabaseFirst.Entities
{
    public class Asset
    {
        public int AssetID { get; set; }
        public string AssetName { get; set; }
        public DateTime AssetBoughtDate { get; set; }
        public decimal AssetPrice { get; set; }
        public string AssetStatus { get; set; }
        public string AssetLocation { get; set; }
    }
}
