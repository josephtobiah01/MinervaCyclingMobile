using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinervaCyclingMobileApp.Models.ApiRequest
{
    public class RepairCenterRequest
    {
        public string Streetname { get; set; }
        public string Postalcode { get; set; }
        public string Cityname { get; set; }
        public string Country { get; set; }
        public int LimitArea { get; set; }
    }
}
