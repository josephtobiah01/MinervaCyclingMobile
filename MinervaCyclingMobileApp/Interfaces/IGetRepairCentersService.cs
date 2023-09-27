using MinervaCyclingMobileApp.Models.ApiRequest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MinervaCyclingMobileApp.Models.ApiResponse.RepairCenterResponse;

namespace MinervaCyclingMobileApp.Interfaces
{
    public interface IGetRepairCentersService
    {
        Task<List<ShopRepair>> GetRepairCenters(RepairCenterRequest request);
    }
}
