using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinervaCyclingMobileApp.Models.ApiRequest
{
    public class CreateShopOrderRequest
    {
        public string UserID { get; set; }
        public string ArticleID { get; set; }
        public float Price { get; set; }
    }
}
