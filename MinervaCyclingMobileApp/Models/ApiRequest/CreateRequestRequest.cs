using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinervaCyclingMobileApp.Models.ApiRequest
{
    public class CreateRequestRequest
    {
        public string ClientID { get; set; }
        public string CertificationID { get; set; }
        public string ShopID { get; set; }
        public bool IsMaintenance { get; set; }
        public bool IsRepair { get; set; }
        public DateTime RequestDateVisit { get; set; }
        public string IssueID { get; set; }
        public string IssueBikeImage { get; set; }  // Optional
        public string IssueBikeDisplay { get; set; }  // Optional
    }
}
