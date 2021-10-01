using System;
using System.Text;
using System.Collections.Generic;

using TLC.Core.Models;
using TLC.Data.Models;
using TLC.Data.Services.Interfaces;

namespace TLC.Data.Services
{
    public static class Seeder
    {
        // use this class to seed the database with dummy 
        // test data using an IUserService 
         public static void Seed(IUserServiceDb svc, IProductServiceDb svcP, IBasketServiceDb svcB, IOrderServiceDb svcO)
        {
            svc.Initialise();

            // add users
            svc.AddUser("Administrator", "admin@mail.com", "admin", Role.Admin);
            svc.AddUser("Manager", "manager@mail.com", "manager", Role.Manager);
            svc.AddUser("Guest", "guest@mail.com", "guest", Role.Guest);

            // add sushiboxes
           var prod1 = svcP.AddProduct("Sushi Box",
                            "Salmon Nigiris, Salmon & Avocado California Roll, Spiced Salmon & Cucumber Maki",
                            "https://images.unsplash.com/photo-1556906918-c3071bd11598?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=800&q=80",
                            ProductType.Boxes,
                            16,
                            15.00,
                            10);
            var prod2 = svcP.AddProduct("Vegan Box",
                            "Spicy jackfruit, Avocado, cabbage Uramaki & BBQ Hispi Cabbage, Cucumber, miso, Maki",
                            "https://images.unsplash.com/photo-1556906918-c3071bd11598?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=800&q=80",
                            ProductType.Boxes,
                            16,
                            15.00,
                            10);
            var prod3 = svcP.AddProduct("Special Box",
                            "BBQ’D Korean beef, cucumber, pickled cabbage futomaki & spicy shrimp, mango salsa, kewpie, uramaki",
                            "https://images.unsplash.com/photo-1556906918-c3071bd11598?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=800&q=80",
                            ProductType.Boxes,
                            16,
                            18.00,
                            10);
            var prod4 = svcP.AddProduct("Special",
                            "BBQ’D Korean beef, cucumber, pickled cabbage futomaki & spicy shrimp, mango salsa, kewpie, uramaki",
                            "https://images.unsplash.com/photo-1556906918-c3071bd11598?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=800&q=80",
                            ProductType.IndividualRolls,
                            12,
                            18.00,
                            10);
            var prod5 = svcP.AddProduct("Poke Bowl",
                            "BBQ’D Korean beef, cucumber, pickled cabbage futomaki & spicy shrimp, mango salsa, kewpie, uramaki",
                            "https://images.unsplash.com/photo-1556906918-c3071bd11598?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=800&q=80",
                            ProductType.PokeBowls,
                            1,
                            18.00,
                            10);

            /*// add Basket
            var basket = svcB.CreateBasket();

            // add BasketItem
            var basketItem1 = svcB.AddProduct(basket.Id, prod1.Id);
            var basketItem2 = svcB.AddProduct(basket.Id, prod2.Id);
            var basketItem3 = svcB.AddProduct(basket.Id, prod3.Id);
            var basketItem4 = svcB.AddProduct(basket.Id, prod4.Id);

            // create Order
            Order newOrder = new Order
            {
                CustomerName = "sean",
                CustomerAddress = "address 1",
                Delivery = false,
                DeliveryDate = new DateTime(2021 / 12 / 25),
                CustBasketId = basket.Id,
                TotalPrice = basket.TotalPrice
                // BasketItems = basket.BasketItems
            };
            // add orders
            var order1 = svcO.CreateOrder(newOrder);*/


        }
    }
}
