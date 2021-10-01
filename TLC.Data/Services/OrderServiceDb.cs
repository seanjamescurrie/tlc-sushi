using Microsoft.Build.Tasks.Deployment.Bootstrapper;
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
    public class OrderServiceDb : IOrderServiceDb
    {
        private readonly DatabaseContext ctx;

        public OrderServiceDb()
        {
            ctx = new DatabaseContext();
        }
        public void Initialise()
        {
            ctx.Initialise();
        }

        /*private readonly IDbContextFactory<DatabaseContext> ctx;

        public OrderServiceDb(IDbContextFactory<DatabaseContext> ctx)
        {
            this.ctx = ctx;
        }
*/


        // ------------------ Order Related Operations ------------------------

        public IList<Order> GetOrders()
        {
            /*using (var ct = ctx.CreateDbContext())
            {
                return ct.Orders.ToList();
            }*/

            return ctx.Orders.ToList();

        }

        public IList<Order> GetOrders(DateTime deliveryDate)
        {
            return ctx.Orders.Where(order => order.DeliveryDate == deliveryDate)
                            .ToList();
        }

        public Order GetOrder(int id)
        {
            return ctx.Orders.FirstOrDefault(order => order.Id == id);
        }

        public Order CreateOrder()
        {
            var order = new Order();

            ctx.Orders.Add(order);
            ctx.SaveChanges();
            return order;
        }

        public Order CreateOrder(Order newOrder)
        {
            var order = new Order
            {
                CustomerName = newOrder.CustomerName,
                CustomerAddress = newOrder.CustomerAddress,
                EmailAddress = newOrder.EmailAddress,
                Delivery = newOrder.Delivery,
                DeliveryDate = newOrder.DeliveryDate,
                CustBasketId = newOrder.CustBasketId,
                TotalPrice = newOrder.TotalPrice,

                // Causing exception "SqliteException: SQLite Error 19: 'UNIQUE constraint failed: Products.Id'."
                BasketItems = newOrder.BasketItems

            };

            ctx.Orders.Add(order);
            ctx.SaveChanges();
            return order;
        }

        //--- Not eeded as we can create order initally then update
        /*public Order AddOrder(string custName, string address, bool delivery, DateTime deliveryDate, Basket basket)
        {
            var order = new Order
            {
                CustomerName = custName,
                CustomerAddress = address,
                Delivery = delivery,
                DeliveryDate = deliveryDate,
                CustBasketId = basket.Id,
                TotalPrice = basket.TotalPrice,

                // Causing exception "SqliteException: SQLite Error 19: 'UNIQUE constraint failed: Products.Id'."
                BasketItems = basket.BasketItems
            };
            ctx.SaveChanges();
            return order; // return newly added Order
        }*/

        public Order EditOrder(Order newOrder)
        {
            var oldOrder = GetOrder(newOrder.Id);
            if (oldOrder == null)
            {
                var order = new Order
                {
                    CustomerName = newOrder.CustomerName,
                    CustomerAddress = newOrder.CustomerAddress,
                    EmailAddress = newOrder.EmailAddress,
                    Delivery = newOrder.Delivery,
                    DeliveryDate = newOrder.DeliveryDate,
                    CustBasketId = newOrder.CustBasketId,
                    TotalPrice = newOrder.TotalPrice,
                    // Causing exception "SqliteException: SQLite Error 19: 'UNIQUE constraint failed: Products.Id'."
                    // BasketItems = newOrder.BasketItems
                };

                ctx.Orders.Add(order);
                order.BasketItems = newOrder.BasketItems;
                ctx.SaveChanges();
                return order;
            }

            oldOrder.CustomerName = newOrder.CustomerName;
            oldOrder.CustomerAddress = newOrder.CustomerAddress;
            oldOrder.EmailAddress = newOrder.EmailAddress;
            oldOrder.Delivery = newOrder.Delivery;
            oldOrder.DatePlaced = newOrder.DatePlaced;
            oldOrder.DeliveryDate = newOrder.DeliveryDate;
            oldOrder.CustBasketId = newOrder.CustBasketId;
            oldOrder.BasketItems = newOrder.BasketItems;

            ctx.SaveChanges();
            return oldOrder; // return edited  Order
        }

        public bool DeleteOrder(int id)
        {
            var order = GetOrder(id);
            if (order == null)
            {
                return false;
            }
            ctx.Orders.Remove(order);
            ctx.SaveChanges();
            return true;
        }

        // adding a product to our order or updating quantity through a list of OrderLineItems
        public BasketItem AddBasketItem(int orderId, int productId, int qty, double price)
        {
            var order = GetOrder(orderId);
            var item = order.BasketItems.FirstOrDefault(item => item.ProductId == productId);
            
            // if item is already in list increase quantity of items
            if (item != null)
            {
                item.Quantity += qty;
                return item;
            }
            // if not generate new OrderlineItem(product) in list
            else
            {
                order.BasketItems.Add(new BasketItem
                {
                    ProductId = productId,
                    Quantity = qty,
                    Price = price
                });

                var newItem = order.BasketItems.FirstOrDefault(item => item.ProductId == productId);
                ctx.SaveChanges();
                return newItem;
            }
        }

        // removing product from our order (List<OrderLineItem> LineItems)
        public bool RemoveOrderItem(int orderId, int productId)
        {
            var order = GetOrder(orderId);
            var item = order.BasketItems.FirstOrDefault(item => item.ProductId == productId);
            if (item != null)
            {
                order.BasketItems.Remove(item);
                return true;
            }
            return false;
        }

        public bool OrderFulfillToggle(int id)
        {
            var order = GetOrder(id);
            if (order == null)
            {
                return false;
            }
            /*
            if (order.Fulfilled)
            {
                order.Fulfilled = false;
                ctx.SaveChanges();
                return false;
            }
            order.Fulfilled = true;
            ctx.SaveChanges();
            return false;
            */

            order.Fulfilled = !order.Fulfilled;
            ctx.SaveChanges();
            return  order.Fulfilled;

        }
    }
}
