using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TLC.Blazor.Services.Interfaces;
using TLC.Data.Models;
using TLC.Data.Services;
using TLC.Data.Services.Interfaces;

namespace TLC.Blazor.Services
{
    public class BasketService : IBasketService
    {
        private readonly IBasketServiceDb svc;

        public BasketService(IBasketServiceDb svc)
        {
            this.svc = svc;
        }

        public BasketItem AddProduct(int basketId, int productId)
        {
            return svc.AddProduct(basketId, productId);
        }

        public Basket CreateBasket()
        {
            return svc.CreateBasket();
        }

        public bool DeleteProduct(int basketId, int productId)
        {
            return svc.DeleteProduct(basketId, productId);
        }

        public BasketItem EditQuantity(int basketId, int productId, int qty)
        {
            return svc.EditQuantity(basketId, productId, qty);
        }

        public Task Empty(int basketId)
        {
            return svc.Empty(basketId);
        }

        public Basket GetBasket(int basketId)
        {
            return svc.GetBasket(basketId);
        }

        public IList<Basket> GetBaskets()
        {
            return svc.GetBaskets();
        }
    }
}
