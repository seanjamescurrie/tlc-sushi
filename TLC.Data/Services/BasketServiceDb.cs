using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TLC.Data.Models;
using TLC.Data.Repositories;
using TLC.Data.Services;
using TLC.Data.Services.Interfaces;

namespace TLC.Data.Services
{
    public class BasketServiceDb : IBasketServiceDb
    {

        private readonly DatabaseContext ctx;

        public BasketServiceDb()
        {
            ctx = new DatabaseContext();
        }
        public void Initialise()
        {
            ctx.Initialise();
        }

        // ------------------ Basket Related Operations ------------------------
        
        /*public async Task<Basket> GetBasketAsync(int? id)
        {
            
            var basket = ctx.Baskets.Include(prod => prod.BasketItems)
                                    .FirstOrDefault(basket => basket.Id == id);
            

            if(basket != null)
            {
                return basket;
            }

            var newBasket = new Basket()
            {
                Id = (int) id
            };

            await ctx.Baskets.AddAsync(newBasket);
            await ctx.SaveChangesAsync();
            return newBasket;
        }*/

        public Basket CreateBasket()
        {
            var basket = new Basket();

            ctx.Baskets.Add(basket);
            ctx.SaveChanges();
            return basket;
        }

        public Basket GetBasket(int id)
        {

            return ctx.Baskets.Include(bask => bask.BasketItems)
                                .FirstOrDefault(bask => bask.Id == id);

            // return first object from db
            /*return ctx.Baskets.Include(bask => bask.BasketItems)
                                .ThenInclude(bI => bI.Product)
                                .FirstOrDefault();*/

        }



        public IList<Basket> GetBaskets()
        {

            return ctx.Baskets.ToList();
        }

        public BasketItem AddProduct(int basketId, int productId)
        {

            // var basketItem = new BasketItem();
            var basket = GetBasket(basketId);

            if (basket == null)
            {
                return null;
            }

            // --- handle increase quantity and price if add product hit twice

            var existingBI = basket.BasketItems.FirstOrDefault(bI => bI.ProductId == productId);

            if(existingBI != null)
            {
                var newQty = existingBI.Quantity += 1;

                // handled in edit qauntity
                //basket.TotalPrice += existingBI.Price;

                return EditQuantity(basketId, productId, newQty);
            }

            // add product to basketItem table

            var product = ctx.Products.FirstOrDefault(product => product.Id == productId);
            if (product == null)
            {
                return null;
            }

            var basketItem = new BasketItem
            {
                ProductId = productId,
                BasketId = basketId,
                // Product = product,
                Price = product.Price,
                Quantity = 1
            };
            basket.TotalPrice += basketItem.Price;

            ctx.BasketItems.Add(basketItem);
            ctx.SaveChanges();
            return basketItem;
        }

        public bool DeleteProduct(int basketId, int productId)
        {
            var basketItem = GetItem(basketId, productId);
            var basket = GetBasket(basketId);
            
            if (basketItem == null || basket == null)
            {
                return false;
            }           
            
            basket.BasketItems.Remove(basketItem);
            var deleted = DeleteItem(basketId, productId);
            ctx.SaveChanges();

            return deleted;
        }

        public BasketItem EditQuantity(int basketId, int productId, int qty)
        {
            var basket = GetBasket(basketId);
            if (basket == null)
            {
                return null;
            }
            var basketItem = GetItem(basketId, productId);
            
            basketItem.Quantity = qty;
            basket.TotalPrice += basketItem.Price;
            var updatedBasketItem = EditItem(basketItem);

            ctx.SaveChanges();
            return basketItem;
        }

        /*public Task<Order> PlaceOrderAsync()
        {
            throw new NotImplementedException();
        }*/

        public async Task Empty(int basketId)
        {
            var items = ctx.BasketItems.Where(item => item.BasketId.Equals(basketId)).ToList();
            ctx.BasketItems.RemoveRange(items);

            var basket = GetBasket(basketId);

            ctx.Baskets.Remove(basket);
            await ctx.SaveChangesAsync();
        }


        // ------------------ BasketItem Related Operations ------------------------

        public IList<BasketItem> GetItems(int basketId)
        {

            var basketItems = ctx.BasketItems.Where(basketItem => basketItem.BasketId == basketId).ToList();
            return basketItems;
        }

        public BasketItem GetItem(int basketId, int productId)
        {
            
            var basketItem = ctx.BasketItems.FirstOrDefault(basketItem => basketItem.BasketId == basketId && basketItem.ProductId == productId);
            return basketItem;
        }

        /*public BasketItem AddItem(int basketId, int productId)
        {
            var product = ctx.Products.FirstOrDefault(product => product.Id == productId);
            if (product == null)
            {
                return null;
            }
            
            var basket = ctx.Baskets.FirstOrDefault(basket => basket.Id == basketId);
            if (basket == null)
            {
                return null;
            }

            var basketItem = new BasketItem
            {
                ProductId = productId,
                BasketId = basketId,
                Product = product,
                Price = product.Price,
                Quantity = 1
            };

            ctx.BasketItems.Add(basketItem);
            ctx.SaveChanges();
            return basketItem;
            


        }*/

        public bool DeleteItem(int basketId, int productId)
        {
            var basketItem = GetItem(basketId, productId);
            if (basketItem == null)
            {
                return false;
            }
            ctx.BasketItems.Remove(basketItem);
            ctx.SaveChanges();
            return true;
        }

        public BasketItem EditItem(BasketItem basketItem)
        {
            //int id = (int)basketItem.Id;
            var item = GetItem(basketItem.ProductId, basketItem.BasketId);
            if (item == null)
            {
                return null;
            }
            item.Price = basketItem.Price;
            // item.Product = basketItem.Product;
            item.ProductId = basketItem.ProductId;
            item.Quantity = basketItem.Quantity;
            item.BasketId = basketItem.BasketId;
            ctx.SaveChanges();
            return item;
        }
    }
}
