﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TLC.Data.Models;

namespace TLC.Data.Services.Interfaces
{

    // abstraction 
    public interface IBasketServiceDb
    {

        // Initialise the repository - only to be used during development 
        void Initialise();


        //----- Basket Functions
        IList<Basket> GetBaskets();

        public Basket GetBasket(int id);
        Basket CreateBasket();
        BasketItem AddProduct(int basketId, int productId);
        BasketItem EditQuantity(int basketId, int productId, int qty);
        bool DeleteProduct(int basketId, int productId);
        // Task<Order> PlaceOrderAsync();
        Task Empty(int basketId);


        //----- BasketItem Functions

        IList<BasketItem> GetItems(int basketId);
        BasketItem GetItem(int basketId, int productId);

        // BasketItem AddItem(int basketId, int productId);
        BasketItem EditItem(BasketItem item);
        bool DeleteItem(int basketId, int productId);

    }
}
