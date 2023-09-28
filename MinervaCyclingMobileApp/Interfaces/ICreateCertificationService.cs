using MinervaCyclingMobileApp.Models.ApiRequest;
using MinervaCyclingMobileApp.Models.ApiResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinervaCyclingMobileApp.Interfaces
{
    public interface ICreateCertificationService
    {
        Task<CreateCertificationResponse> CreateCertificationAsync(CreateCertificationRequest request);
    }
}
