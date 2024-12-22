using System.Threading.Tasks;
using Muresan_DianaBeatrice_Lab11.Models;

namespace Muresan_DianaBeatrice_Lab11.Data
{
    public interface IRestService
    {
        Task<List<ShopList>> RefreshDataAsync();
        Task SaveShopListAsync(ShopList item, bool isNewItem);
        Task DeleteShopListAsync(int id);
    }
}
