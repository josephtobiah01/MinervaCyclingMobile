using MinervaCyclingMobileApp.Models.ApiResponse;
using MinervaCyclingMobileApp.Models.ApiRequest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinervaCyclingMobileApp.Interfaces;

namespace MinervaCyclingMobileApp.Services
{
    public class GetRequestsService : IGetRequestsService
    {

        public async Task<OverviewRequestsResponse> GetRequests(OverviewRequestsRequest request)
        {
            var response = await GetData(request);
            return response;
        }

        public Task<OverviewRequestsResponse> GetData(OverviewRequestsRequest requestModel)
        {
            var mockResponse = new OverviewRequestsResponse
            {
                TotalOfRows = 9,
                PagePosition = requestModel.PagePosition,
                PageSize = requestModel.PageSize,
                RequestsListModel = new List<OverviewRequestsResponse.RequestsDetails>
                {
                    new OverviewRequestsResponse.RequestsDetails { RepairCaseID = "123", Status = "Completed", TotalCosts = 150.5f, ShopName = "Bruges Shop" },
                    //Add more mocked data as needed
                }
            };

            return Task.FromResult(mockResponse);
        }

        
    }
}
