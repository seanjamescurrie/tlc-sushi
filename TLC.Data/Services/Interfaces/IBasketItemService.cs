/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TLC.Data.Models;

namespace TLC.Data.Services
{
    public interface IBasketItemService
    {

        // Initialise the repository - only to be used during development 
        void Initialise();

        IList<BasketItem> GetItems(int basketId);
        Task<BasketItem> GetItemAsync(int basketId, int productId);
        Task<BasketItem> AddItemAsync(int basketId, int productId);
        Task<BasketItem> EditItemAsync(BasketItem item);
        Task<bool> DeleteItemAsync(int basketId, int productId);

    }
}
*/

// ------- Moved into IBasketService