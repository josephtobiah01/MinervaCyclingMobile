using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinervaCyclingMobileApp.Models.ApiResponse
{
    public class UserDetailsResponse
    {
        public class UserLoginDetails
        {
            public string Email { get; set; }
            public string Password { get; set; }
        }
        

        public List<UserLoginDetails> UserLoginDetailsModel { get; set; }
    }
}
