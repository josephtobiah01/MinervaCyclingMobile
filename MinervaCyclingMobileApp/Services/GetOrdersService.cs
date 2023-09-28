using MinervaCyclingMobileApp.Interfaces;
using MinervaCyclingMobileApp.Models.ApiRequest;
using MinervaCyclingMobileApp.Models.ApiResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinervaCyclingMobileApp.Services
{
    public class GetOrdersService : IGetOrdersService
    {
        public async Task<GetOrdersResponse> GetOrders(GetOrdersRequest orderRequest)
        {
            var response = await FetchOrdersData(orderRequest);
            return response;
        }

        public Task<GetOrdersResponse> FetchOrdersData(GetOrdersRequest orderRequest)
        {
            // This is mocked for the sake of example:
            var mockResponse = new GetOrdersResponse
            {
                OrdersList = new List<GetOrdersResponse.Order>
                {
                    new GetOrdersResponse.Order
                    {
                        OrderID = "ORDER1234",
                        OrderDate = DateTime.Now,
                        ArticleID = "ART123",
                        Article = "Article Name",
                        Price = 100.0f
                    }
                    
                },
                TotalOfRows = 10,
                PagePosition = orderRequest.PagePosition,
                PageSize = orderRequest.PageSize
            };

            return Task.FromResult(mockResponse);
        }
    }
}
