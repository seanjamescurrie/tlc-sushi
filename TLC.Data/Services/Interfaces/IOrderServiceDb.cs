using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TLC.Data.Models;

namespace TLC.Data.Services.Interfaces
{
    public interface IOrderServiceDb
    {
        // Initialise the repository - only to be used during development 
        void Initialise();

        // ---------------- Order Management --------------
        IList<Order> GetOrders();
        IList<Order> GetOrders(DateTime deliveryDate);
        Order GetOrder(int id);
        Order CreateOrder();
        Order CreateOrder(Order newOrder);
        // Order AddOrder(string custName, string address, bool delivery, DateTime deliveryDate, Basket basket);
        Order EditOrder(Order order);
        bool DeleteOrder(int id);
        BasketItem AddBasketItem(int orderId, int productId, int qty, double price);
        bool RemoveOrderItem(int orderId, int productId);
        bool OrderFulfillToggle(int id);
    }
}