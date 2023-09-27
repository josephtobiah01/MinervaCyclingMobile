using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MinervaCyclingMobileApp.Models.ApiResponse.BikeIssuesResponse;

namespace MinervaCyclingMobileApp.Interfaces
{
    public interface IGetBikeIssuesService
    {
        Task<List<BikeIssue>> GetBikeIssues();
    }
}
