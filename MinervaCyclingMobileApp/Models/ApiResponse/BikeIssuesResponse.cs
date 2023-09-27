using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinervaCyclingMobileApp.Models.ApiResponse
{
    public class BikeIssuesResponse
    {
        public class BikeIssue
        {
            public string IssueID { get; set; }
            public string IssueName { get; set; }
        }

        public List<BikeIssue> BikeIssuesListModel { get; set; }
    }
}
