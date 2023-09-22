using MinervaCyclingMobileApp.Interfaces;
using MinervaCyclingMobileApp.Models.ApiResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MinervaCyclingMobileApp.Models.ApiResponse.ShopDetailsResponse;

namespace MinervaCyclingMobileApp.Services
{
    public class GetShopsService : IGetShopsService
    {

        public async Task<List<ShopDetailsResponse.ShopDetails>> GetShops()
        {

            var response = await GetData();
            //List<ShopDetailsResponse> shopItems = new List<ShopDetailsResponse>();
            //var response = await GetData();

            //foreach(var item in response)
            //{
            //    foreach(var shop in item.ShopsListModel)
            //    {
            //        shopItems.Add(new ShopDetails
            //        {
            //            ShopName = shop.ShopName,
            //        });
                    
                    
            //    }
            //}

            return response;
        }

        public Task<List<ShopDetailsResponse.ShopDetails>> GetData()
        {
            ShopDetailsResponse.ShopDetails model = new ShopDetailsResponse.ShopDetails();

            var shopDetailsList = new List<ShopDetailsResponse.ShopDetails>
            {
                new ShopDetailsResponse.ShopDetails{ShopName = "Bruges Shop", ShopId = "1"},
                new ShopDetailsResponse.ShopDetails{ShopName = "Brussels Shop", ShopId = "2"},
                new ShopDetailsResponse.ShopDetails{ShopName = "Namur Shop", ShopId = "3"},
                new ShopDetailsResponse.ShopDetails{ShopName = "Liege Shop", ShopId = "4"},
                new ShopDetailsResponse.ShopDetails{ShopName = "Charleroi Shop", ShopId = "5"},
                new ShopDetailsResponse.ShopDetails{ShopName = "Leuven Shop", ShopId = "6"},
                new ShopDetailsResponse.ShopDetails{ShopName = "Ghent Shop", ShopId = "7"},
                new ShopDetailsResponse.ShopDetails{ShopName = "Ostend Shop", ShopId = "8"},
                new ShopDetailsResponse.ShopDetails{ShopName = "Antwerp Shop", ShopId = "9"},
            };

            shopDetailsList.Add(model);
            //return shopDetailsList;

            return Task.FromResult(shopDetailsList);
        }
    }
}
