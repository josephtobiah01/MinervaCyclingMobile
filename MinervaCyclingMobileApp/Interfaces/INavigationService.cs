using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinervaCyclingMobileApp.Interfaces
{
    public interface INavigationService
    {
        Task NavigateTo<T>(Dictionary<string, object> parameter = null) where T : Page;
        Task NavigateTo(string page, Dictionary<string, object> parameter = null);
        Task GoBack();
    }
}
