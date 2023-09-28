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
    public class CreateShopOrderService : ICreateShopOrderService
    {
        public async Task<CreateShopOrderResponse> PlaceOrder(CreateShopOrderRequest orderRequest)
        {
            var response = await SendOrderData(orderRequest);

            return response;
        }

        public Task<CreateShopOrderResponse> SendOrderData(CreateShopOrderRequest orderRequest)
        {
            // Mocked response for now
            var mockResponse = new CreateShopOrderResponse
            {
                OrderID = "ORDER1234"  // in real-world, this would come from the API
            };

            return Task.FromResult(mockResponse);
        }
    }
}
