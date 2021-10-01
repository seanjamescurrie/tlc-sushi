using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TLC.Data.Models;

namespace TLC.Blazor.Services.Interfaces
{
    public interface IOrderService
    {
        // ---------------- Order Management --------------
        IList<Order> GetOrders();
        IList<Order> GetOrders(DateTime DeliveryDate);
        Order GetOrder(int id);
        Order CreateOrder();
        Order CreateOrder(Order order);
        // Order AddOrder(string custName, string address, bool delivery, DateTime deliveryDate, Basket basket);
        Order EditOrder(Order order);
        bool DeleteOrder(int id);
        BasketItem AddOrderItem(int orderId, int productId, int qty, double price);
        bool RemoveOrderItem(int orderId, int productId);
        bool OrderFulfillToggle(int id);
    }
}
