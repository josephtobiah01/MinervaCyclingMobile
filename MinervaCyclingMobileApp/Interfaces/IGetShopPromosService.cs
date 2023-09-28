using MinervaCyclingMobileApp.Models.ApiRequest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MinervaCyclingMobileApp.Models.ApiResponse.GetPromosResponse;

namespace MinervaCyclingMobileApp.Interfaces
{
    public interface IGetShopPromosService
    {
        Task<List<ShopArticle>> GetShopPromos(GetPromosRequest request);
    }
}
