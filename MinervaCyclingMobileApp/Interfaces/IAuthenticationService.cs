using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinervaCyclingMobileApp.Interfaces
{
    public interface IAuthenticationService
    {
        Task<bool> Login(string email, string password);
    }
}
