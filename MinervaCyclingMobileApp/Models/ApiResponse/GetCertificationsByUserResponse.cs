using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinervaCyclingMobileApp.Models.ApiResponse
{
    public class GetCertificationsByUserResponse
    {
        public class CertificationItem
        {
            public string CertificationNO { get; set; }
            public string ProductName { get; set; }
            public DateTime? LastMaintenance { get; set; }
            public DateTime WarantyEnd { get; set; }
            public string ProductImage { get; set; }
            public bool HasInsurrance { get; set; }
            public string InsurrancePack { get; set; }
            public bool WarantyExpired { get; set; }
        }

        public List<CertificationItem> Certifications { get; set; }
    }
}
