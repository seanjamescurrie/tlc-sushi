/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TLC.Data.Models;
using TLC.Data.Repositories;

namespace TLC.Data.Services
{
    public class BasketItemServiceDb : IBasketItemService
    {
        private readonly DatabaseContext ctx;

        public BasketItemServiceDb()
        {
            ctx = new DatabaseContext();
        }
        public void Initialise()
        {
            ctx.Initialise();
        }

        // ------------------ BasketItem Related Operations ------------------------

        public IList<BasketItem> GetItems(int basketId)
        {
            
            var basketItems = ctx.BasketItems.Where(basketItem => basketItem.BasketId == basketId).ToList();
            return basketItems;
        }

        public async Task<BasketItem> GetItemAsync(int basketId, int productId)
        {
            await Task.Delay(200);
            var basketItem = ctx.BasketItems.FirstOrDefault(basketItem => basketItem.BasketId == basketId && basketItem.ProductId == productId);
            return basketItem;
        }

        public async Task<BasketItem> AddItemAsync(int basketId, int productId)
        {
            await Task.Delay(200);
            var product = ctx.Products.FirstOrDefault(product => product.Id == productId);
            if (product == null)
            {
                return null;
            }

            BasketItem productItem = new BasketItem();
            productItem.ProductId = productId;
            productItem.BasketId = basketId;
            productItem.Product = product;
            productItem.Price = product.Price;

            ctx.BasketItems.Add(productItem);
            ctx.SaveChanges();
            return productItem;


        }

        public async Task<bool> DeleteItemAsync(int basketId, int productId)
        {
            var basketItem = await GetItemAsync(basketId, productId);
            if (basketItem == null)
            {
                return false;
            }
            ctx.BasketItems.Remove(basketItem);
            ctx.SaveChanges();
            return true;
        }

        public async Task<BasketItem> EditItemAsync(BasketItem basketItem)
        {
            int id = (int) basketItem.Id;
            var item = await GetItemAsync(basketItem.ProductId, basketItem.BasketId);
            if (item == null)
            {
                return null;
            }
            item.Price = basketItem.Price;
            item.Product = basketItem.Product;
            item.ProductId = basketItem.ProductId;
            item.Quantity = basketItem.Quantity;
            item.BasketId = basketItem.BasketId;
            ctx.SaveChanges();
            return item;
        }
    }
}
*/

// ------- Moved into BasketServiceDb