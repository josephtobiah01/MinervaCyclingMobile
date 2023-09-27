using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinervaCyclingMobileApp.Models.ApiResponse
{
    public class RepairCenterResponse
    {
        public class ShopRepair
        {
            public string ShopRepairID { get; set; }
            public string ShopName { get; set; }
            public string Address { get; set; }
            public string Postalcode { get; set; }
            public string City { get; set; }
            public string Country { get; set; }
        }

        public List<ShopRepair> RepairCenterListModel { get; set; }
    }
}
