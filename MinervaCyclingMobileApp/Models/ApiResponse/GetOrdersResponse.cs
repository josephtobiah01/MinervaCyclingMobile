using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinervaCyclingMobileApp.Models.ApiResponse
{
    public class GetOrdersResponse : BaseResponse
    {
        public class Order
        {
            public string OrderID { get; set; }
            public DateTime OrderDate { get; set; }
            public string ArticleID { get; set; }
            public string Article { get; set; }
            public float Price { get; set; }
        }

        public List<Order> OrdersList { get; set; }
        public int TotalOfRows { get; set; }
        public int PagePosition { get; set; }
        public int PageSize { get; set; }
    }
}
