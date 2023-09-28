using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinervaCyclingMobileApp.Models.ApiResponse
{
    public class OverviewRequestsResponse : BaseResponse
    {
        public class RequestsDetails
        {
            public string RepairCaseID { get; set; }
            public string Status { get; set; }
            public float TotalCosts { get; set; }
            public string ShopName { get; set; }
        }

        public List<RequestsDetails> RequestsListModel { get; set; }
        public int TotalOfRows { get; set; }
        public int PagePosition { get; set; }
        public int PageSize { get; set; }
    }
}
