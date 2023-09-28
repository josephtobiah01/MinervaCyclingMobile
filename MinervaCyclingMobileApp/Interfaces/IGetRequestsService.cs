using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinervaCyclingMobileApp.Models.ApiRequest;
using MinervaCyclingMobileApp.Models.ApiResponse;

namespace MinervaCyclingMobileApp.Interfaces
{
    public interface IGetRequestsService
    {
        Task<OverviewRequestsResponse> GetRequests(OverviewRequestsRequest request);
    }
}
