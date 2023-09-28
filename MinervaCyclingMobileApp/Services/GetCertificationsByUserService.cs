using MinervaCyclingMobileApp.Interfaces;
using MinervaCyclingMobileApp.Models.ApiRequest;
using MinervaCyclingMobileApp.Models.ApiResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MinervaCyclingMobileApp.Models.ApiResponse.GetCertificationsByUserResponse;

namespace MinervaCyclingMobileApp.Services
{
    public class GetCertificationsByUserService : IGetCertificationsByUserService
    {
        public async Task<List<CertificationItem>> GetCertificationsByUser(GetCertificationsByUserRequest request)
        {
            var response = await GetData(request);
            return response.Certifications;
        }

        private Task<GetCertificationsByUserResponse> GetData(GetCertificationsByUserRequest request)
        {
            //example
            if (request.UserID == "123")
            {
                var certificationsList = new List<CertificationItem>
        {
            new CertificationItem
            {
                CertificationNO = "CERT001",
                ProductName = "Bike Model A",
                LastMaintenance = DateTime.Now.AddDays(-10),
                WarantyEnd = DateTime.Now.AddYears(1),
                ProductImage = "image1",
                HasInsurrance = true,
                InsurrancePack = "Basic",
                WarantyExpired = false
            },
            new CertificationItem
            {
                CertificationNO = "CERT002",
                ProductName = "Bike Model B",
                LastMaintenance = DateTime.Now.AddDays(-20),
                WarantyEnd = DateTime.Now.AddMonths(6),
                ProductImage = "image2",
                HasInsurrance = false,
                InsurrancePack = "",
                WarantyExpired = false
            }
            //Add more mockup data as needed
        };

                var response = new GetCertificationsByUserResponse
                {
                    Certifications = certificationsList
                };

                return Task.FromResult(response);
            }
            else
            {
                // Handle other UserIDs or return a default/empty list.
                return Task.FromResult(new GetCertificationsByUserResponse { Certifications = new List<CertificationItem>() });
            }
        }

    }
}
