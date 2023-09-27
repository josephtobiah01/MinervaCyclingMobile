using MinervaCyclingMobileApp.Interfaces;
using MinervaCyclingMobileApp.Models.ApiRequest;
using MinervaCyclingMobileApp.Models.ApiResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MinervaCyclingMobileApp.Models.ApiResponse.RepairCenterResponse;


namespace MinervaCyclingMobileApp.Services
{
    public class GetRepairCentersService : IGetRepairCentersService
    {
        public async Task<List<ShopRepair>> GetRepairCenters(RepairCenterRequest request)
        {
            var response = await GetData(request);

            return response;
        }

        public Task<List<ShopRepair>> GetData(RepairCenterRequest request)
        {
            
            var repairCenterList = new List<ShopRepair>
            {
                new ShopRepair
                {
                    ShopRepairID = "1",
                    ShopName = "Bruges Repair Center",
                    Address = "Main Street",
                    Postalcode = "1000",
                    City = "Bruges",
                    Country = "Belgium"
                }
            };

            return Task.FromResult(repairCenterList);
        }
    }
}
