using MinervaCyclingMobileApp.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinervaCyclingMobileApp.Models
{
    public class UserDetails : BindableBase
    {
        private string _email;
        public string Email 
        {
            get { return _email; }
            set { SetPropertyValue(ref _email, value); }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set { SetPropertyValue(ref _password, value); }
        }
    }
}
