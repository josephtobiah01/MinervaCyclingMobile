using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinervaCyclingMobileApp.Models.ApiResponse
{
    public class CreateRequestResponse : BaseResponse
    {
        public string RepairCaseID { get; set; }
        public bool NoCharge { get; set; }
        public float TotalRepairCost { get; set; }
        public float RepairCostAtHome { get; set; }
        public List<RepairItem> RepairItemsList { get; set; }

        public class RepairItem
        {
            public string ItemID { get; set; }
            public string Name { get; set; }
            public float Price { get; set; }
        }
    }
}
