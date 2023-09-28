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
    public class CreateRequestService : ICreateRequestService
    {
        public async Task<CreateRequestResponse> CreateRequest(CreateRequestRequest request)
        {
            var response = await GetData(request);
            return response;
        }

        public Task<CreateRequestResponse> GetData(CreateRequestRequest request)
        {
            var response = new CreateRequestResponse
            {
                RepairCaseID = "12345",
                NoCharge = false,
                TotalRepairCost = 150.5f,
                RepairCostAtHome = 50.5f,
                RepairItemsList = new List<CreateRequestResponse.RepairItem>
                {
                    new CreateRequestResponse.RepairItem { ItemID = "A1", Name = "Brake Repair", Price = 50f },
                    new CreateRequestResponse.RepairItem { ItemID = "B2", Name = "Tyre Change", Price = 25.5f }
                }
            };

            return Task.FromResult(response);
        }
    }
}
