using MinervaCyclingMobileApp.Interfaces;
using MinervaCyclingMobileApp.Models.ApiResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MinervaCyclingMobileApp.Models.ApiResponse.BikeIssuesResponse;

namespace MinervaCyclingMobileApp.Services
{
    public class GetBikeIssuesService : IGetBikeIssuesService
    {
        public async Task<List<BikeIssue>> GetBikeIssues()
        {
            var response = await GetData();

            return response;
        }

        public Task<List<BikeIssue>> GetData()
        {
            
            var bikeIssuesList = new List<BikeIssue>
            {
                new BikeIssue { IssueID = "1", IssueName = "Flat Tire" },
                new BikeIssue { IssueID = "2", IssueName = "Broken Chain" },
            };

            return Task.FromResult(bikeIssuesList);
        }
    }
}
