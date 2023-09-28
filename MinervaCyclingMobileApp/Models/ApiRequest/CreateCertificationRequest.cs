using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinervaCyclingMobileApp.Models.ApiRequest
{
    public class CreateCertificationRequest
    {
        public string ClientID { get; set; }
        public string ShopID { get; set; }
        public DateTime BuyDate { get; set; }
        public string ShopTicket { get; set; }
        public string BatteryBarcode { get; set; }
    }
}
