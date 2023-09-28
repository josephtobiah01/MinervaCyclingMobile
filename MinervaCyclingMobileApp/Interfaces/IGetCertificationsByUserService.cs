using MinervaCyclingMobileApp.Models.ApiRequest;
using MinervaCyclingMobileApp.Models.ApiResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MinervaCyclingMobileApp.Models.ApiResponse.GetCertificationsByUserResponse;

namespace MinervaCyclingMobileApp.Interfaces
{
    public interface IGetCertificationsByUserService
    {
        Task<List<CertificationItem>> GetCertificationsByUser(GetCertificationsByUserRequest request);
    }
}
