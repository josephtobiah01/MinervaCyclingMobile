using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinervaCyclingMobileApp.Models.ApiResponse
{
    public class GetPromosResponse
    {
        public class ShopArticle
        {
            public string ArticleID { get; set; }
            public string Name { get; set; }
            public string Image { get; set; }
            public float Price { get; set; }
        }

        public List<ShopArticle> ShopArticlesListModel { get; set; }
    }
}
