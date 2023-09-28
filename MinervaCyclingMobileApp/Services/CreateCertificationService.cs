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
    public class CreateCertificationService : ICreateCertificationService
    {
        public async Task<CreateCertificationResponse> CreateCertificationAsync(CreateCertificationRequest request)
        {
            await Task.Delay(1000);

            return await GetMockResponse();
        }

        private Task<CreateCertificationResponse> GetMockResponse()
        {
            var mockResponse = new CreateCertificationResponse
            {
                StatusCode = 201,
                Message = "Certification created successfully."
            };

            return Task.FromResult(mockResponse);
        }
    }
}
