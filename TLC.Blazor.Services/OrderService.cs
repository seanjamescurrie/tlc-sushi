using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TLC.Blazor.Services.Interfaces;
using TLC.Data.Models;
using TLC.Data.Services.Interfaces;

namespace TLC.Blazor.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderServiceDb svc;

        public OrderService(IOrderServiceDb svc)
        {
            this.svc = svc;
        }
        /*public Order AddOrder(string custName, string address, bool delivery, DateTime deliveryDate, Basket basket)
        {
            return svc.AddOrder( custName,  address,  delivery,  deliveryDate, basket);
        }*/
        public Order CreateOrder()
        {
            return svc.CreateOrder();
        }

        public Order CreateOrder(Order order)
        {
            return svc.CreateOrder(order);
        }

        public BasketItem AddOrderItem(int orderId, int productId, int qty, double price)
        {
            return svc.AddBasketItem(orderId, productId, qty, price);
        }

        public bool DeleteOrder(int id)
        {
            return svc.DeleteOrder(id);
        }

        public Order EditOrder(Order order)
        {
            return svc.EditOrder(order);
        }

        public Order GetOrder(int id)
        {
            return svc.GetOrder(id);
        }

        public IList<Order> GetOrders()
        {
            return svc.GetOrders();
        }

        public IList<Order> GetOrders(DateTime delivery)
        {
            return svc.GetOrders(delivery);
        }

        public bool OrderFulfillToggle(int id)
        {
            return svc.OrderFulfillToggle(id);
        }

        public bool RemoveOrderItem(int orderId, int productId)
        {
            return svc.RemoveOrderItem(orderId, productId);
        }
    }
}
