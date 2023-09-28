using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinervaCyclingMobileApp.Models.ApiRequest
{
    public class OverviewRequestsRequest
    {
        public string ClientID { get; set; }
        public int PagePosition { get; set; }
        public int PageSize { get; set; }
    }
}
