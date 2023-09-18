using MinervaCyclingMobileApp.Interfaces;
using MinervaCyclingMobileApp.Models.ApiResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MinervaCyclingMobileApp.Models.ApiResponse.UserDetailsResponse;

namespace MinervaCyclingMobileApp.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        public async Task<bool> Login(string email, string password)
        {
            var response = await GetData();

            foreach(var item in response)
            {
                foreach(var user in item.UserLoginDetailsModel)
                {
                    if (user.Email == email && user.Password == password)
                    {
                        return true;
                    }
                }
            }
            return false;
            
        }

        public Task<List<UserDetailsResponse>> GetData()
        {
            UserDetailsResponse model = new UserDetailsResponse();

            model.UserLoginDetailsModel = new List<UserLoginDetails>();

            model.UserLoginDetailsModel.Add(new UserLoginDetails
            {
                Email = "otepalulod@gmail.com",
                Password = "Password123"
            });
            model.UserLoginDetailsModel.Add(new UserLoginDetails
            {
                Email = "joseph@icssolutions.eu",
                Password = "Username123"
            });

            List<UserDetailsResponse> response = new List<UserDetailsResponse>();

            response.Add(model);

            return Task.FromResult(response);
        }
    }
}
