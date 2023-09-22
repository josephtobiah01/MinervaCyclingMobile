using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinervaCyclingMobileApp.Models.ApiResponse
{
    public class ShopDetailsResponse
    {
       public class ShopDetails
        {
            public string ShopId { get; set;}
            public string ShopName { get; set;}
        }

        public List<ShopDetails> ShopsListModel { get; set;}    
    }
}
