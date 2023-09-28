using MinervaCyclingMobileApp.Interfaces;
using MinervaCyclingMobileApp.Models.ApiRequest;
using MinervaCyclingMobileApp.Models.ApiResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MinervaCyclingMobileApp.Models.ApiResponse.GetPromosResponse;


namespace MinervaCyclingMobileApp.Services
{
    public class GetShopPromosService : IGetShopPromosService
    {
        public async Task<List<ShopArticle>> GetShopPromos(GetPromosRequest request)
        {
            var response = await GetData(request);
            return response;
        }

        public Task<List<ShopArticle>> GetData(GetPromosRequest request)
        {
            var articlesList = new List<ShopArticle>
            {
                new ShopArticle
                {
                    ArticleID = "1",
                    Name = "Gloves",
                    Image = "gloves",
                    Price = 59.99f
                },
                new ShopArticle
                {
                    ArticleID = "1",
                    Name = "Helmet",
                    Image = "helmet",
                    Price = 39.99f
                },
                new ShopArticle
                {
                    ArticleID = "1",
                    Name = "Headlights",
                    Image = "headlights",
                    Price = 49.99f
                }
            };

            return Task.FromResult(articlesList);
        }
    }
}
