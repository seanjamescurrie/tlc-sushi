using System;
using Xunit;
using TLC.Core.Models;
using TLC.Core.Security;

using TLC.Data.Services;
using TLC.Data.Services.Interfaces;
using TLC.Data.Models;
using System.Linq;

namespace TLC.Test
{
    public class ServiceTests
    {
        private IUserServiceDb service;
        private IProductServiceDb serviceProd;
        // private IBasketItemService serviceBasketItem;
        private IBasketServiceDb serviceBasket;
        private IOrderServiceDb serviceOrder;

        public ServiceTests()
        {
            service = new UserServiceDb();
            service.Initialise();

            serviceProd = new ProductServiceDb();
            serviceProd.Initialise();

            // serviceBasketItem = new BasketItemServiceDb();
            // serviceBasketItem.Initialise();
            // serviceBasketItem

            serviceBasket = new BasketServiceDb();
            serviceBasket.Initialise();

            serviceOrder = new OrderServiceDb();
            serviceOrder.Initialise();
        }

        //--- User Tests

        [Fact]
        public void EmptyDbShouldReturnNoUsers()
        {
            // act
            var users = service.GetUsers();

            // assert
            Assert.Equal(0, users.Count);
        }

        [Fact]
        public void AddingUsersShouldWork()
        {
            // arrange
            service.AddUser("admin", "admin@mail.com", "admin", Role.Admin);
            service.AddUser("guest", "guest@mail.com", "guest", Role.Guest);

            // act
            var users = service.GetUsers();

            // assert
            Assert.Equal(2, users.Count);
        }

        [Fact]
        public void UpdatingUserShouldWork()
        {
            // arrange
            var user = service.AddUser("admin", "admin@mail.com", "admin", Role.Admin);

            // act
            user.Name = "administrator";
            user.Email = "admin@mail.com";
            var updatedUser = service.UpdateUser(user);

            // assert
            Assert.Equal("administrator", user.Name);
            Assert.Equal("admin@mail.com", user.Email);
        }

        [Fact]
        public void LoginWithValidCredentialsShouldWork()
        {
            // arrange
            service.AddUser("admin", "admin@mail.com", "admin", Role.Admin);

            // act            
            var user = service.Authenticate("admin@mail.com", "admin");

            // assert
            Assert.NotNull(user);

        }



        //------------- Product Tests

        [Fact]
        public void EmptyDbShouldReturnNoProducts()
        {
            // act
            var products = serviceProd.GetProducts();

            // assert
            Assert.Equal(0, products.Count);
        }

        [Fact]
        public void AddingProductsAddProductToDb()
        {
            // arrange
            serviceProd.AddProduct("name", "description", "url.com", ProductType.Boxes, 10, 15.00, 10);
            serviceProd.AddProduct("name2", "description2", "url2.com", ProductType.IndividualRolls, 10, 16.00, 10);

            // act
            var products = serviceProd.GetProducts();

            // assert
            Assert.Equal(2, products.Count);
        }

        [Fact]
        public void GetProductRetrieveProductFromDb()
        {
            // arrange
            var added = serviceProd.AddProduct("name", "description", "url.com", ProductType.Boxes, 10, 15.00, 10);

            // act
            var check = serviceProd.GetProduct(added.Id);

            // assert
            Assert.Equal(added.Id, check.Id);
            Assert.Equal(added.Name, check.Name);
            Assert.Equal(added.Description, check.Description);
            Assert.Equal(added.ImageUrl, check.ImageUrl);
            Assert.Equal(added.ProductType, check.ProductType);
            Assert.Equal(added.Price, check.Price);
            Assert.Equal(added.Limit, check.Limit);
        }

        [Fact]
        public void DeleteProductShouldRemoveProduct()
        {
            // arrange
            var added = serviceProd.AddProduct("name", "description", "url.com", ProductType.Boxes, 10, 15.00, 10);

            // act            
            var removed = serviceProd.DeleteProduct(added.Id);
            var products = serviceProd.GetProducts();

            // assert
            Assert.True(removed);
            Assert.Equal(0, products.Count);

        }

        [Fact]
        public void ArchivingProductShouldReturnTrue()
        {
            // arrange
            var added = serviceProd.AddProduct("name", "description", "url.com", ProductType.Boxes, 10, 15.00, 10);

            // act      
            bool archive = serviceProd.ArchiveProduct(added.Id);
            var archivedProduct = serviceProd.GetProduct(added.Id);
            var notes = serviceProd.GetNotes(archivedProduct.Id);
            var note = notes.FirstOrDefault(n => n.SellingNotes == "Went down a treat");
            // var note = notes.Where(n => n.SellingNotes.Contains("Went down a treat"));

            // assert
            Assert.True(archive);
            Assert.Equal("Went down a treat", note.SellingNotes);

        }

        //------------- Basket Tests


        [Fact]
        public void CreateNewBasketCreatesNewBasket()
        {

            // act
            var basket = serviceBasket.CreateBasket();

            // assert
            Assert.NotNull(basket);
        }

        [Fact]
        public void GetBasketRetrievesBasket()
        {
            // arrange
            var basket = serviceBasket.CreateBasket();

            // act
            var retrieveBasket = serviceBasket.GetBasket(basket.Id);
            var baskets = serviceBasket.GetBaskets();

            // assert
            Assert.NotNull(retrieveBasket);
            Assert.Equal(basket.Id, retrieveBasket.Id);
            Assert.Equal(1, baskets.Count);
        }

        
        [Fact]
        public void AddProductShouldAddProductToBasket()
        {

            // arrange
            var product1 = serviceProd.AddProduct("name", "description", "url.com", ProductType.Boxes, 10, 15.00, 10);
            var product2 = serviceProd.AddProduct("name2", "description2", "url2.com", ProductType.IndividualRolls, 10, 16.00, 10);
            var basket = serviceBasket.CreateBasket();

            // act
            var basketAdd1 = serviceBasket.AddProduct(basket.Id, product1.Id);
            var basketAdd2 = serviceBasket.AddProduct(basket.Id, product2.Id);
            var basketItems = serviceBasket.GetItems(basket.Id);

            // assert
            Assert.NotNull(basketAdd1);
            Assert.NotNull(basketAdd2);
            Assert.Equal(basket.Id, basketAdd1.BasketId);
            Assert.Equal(basket.Id, basketAdd2.BasketId);
            Assert.Equal(2, basketItems.Count);

        }

        [Fact]
        public void EditQuantityShouldChangeBasketItemQuantityt()
        {

            // arrange
            var product1 = serviceProd.AddProduct("name", "description", "url.com", ProductType.Boxes, 10, 15.00, 10);
            var basket = serviceBasket.CreateBasket();

            // act
            var basketAdd1 = serviceBasket.AddProduct(basket.Id, product1.Id);
            var basketItem1 = serviceBasket.GetItem(basket.Id, product1.Id);
            var basketEditted = serviceBasket.EditQuantity(basketItem1.BasketId, basketItem1.ProductId, 2);

            // assert
            Assert.Equal(2, basketItem1.Quantity);

        }

        [Fact]
        public void DeleteProductRemovesProductFromBasket()
        {

            // arrange
            var product1 = serviceProd.AddProduct("name", "description", "url.com", ProductType.Boxes, 10, 15.00, 10);
            var basket = serviceBasket.CreateBasket();

            // act
            var basketAdd1 = serviceBasket.AddProduct(basket.Id, product1.Id);
            var deleted = serviceBasket.DeleteProduct(basket.Id, product1.Id);
            var basketItem1 = serviceBasket.GetItem(basket.Id, product1.Id);

            // assert
            Assert.Null(basketItem1);
            Assert.True(deleted);

        }

        [Fact]
        public void EmptyShouldDeleteBasket()
        {
            // arrange
            var product1 = serviceProd.AddProduct("name", "description", "url.com", ProductType.Boxes, 10, 15.00, 10);
            var basket = serviceBasket.CreateBasket();
            var basketAdd1 = serviceBasket.AddProduct(basket.Id, product1.Id);

            // act
            serviceBasket.Empty(basket.Id);
            var basketDelete = serviceBasket.GetBasket(basket.Id);

            // assert
            Assert.Null(basketDelete);
        }

        //------------- Order Tests

        [Fact]
        public void EmptyDbShouldReturnNoUOrders()
        {
            // act
            var orders = serviceOrder.GetOrders();

            // assert
            Assert.Equal(0, orders.Count);
        }

        [Fact]
        public void Adding_CreatingOrdersShouldWork()
        {
            // arrange
            var basket = serviceBasket.CreateBasket();
            Order newOrder = new Order
            {
                CustomerName = "sean",
                CustomerAddress = "address 1",
                Delivery = false,
                DeliveryDate = new DateTime(2021 / 12 / 25),
                CustBasketId = basket.Id,
                TotalPrice = basket.TotalPrice,
                EmailAddress = "sean@mail.com"
            };
            serviceOrder.CreateOrder(newOrder);
            Order newOrder2 = new Order
            {
                CustomerName = "sean",
                CustomerAddress = "address 1",
                Delivery = false,
                DeliveryDate = new DateTime(2021 / 12 / 25),
                CustBasketId = basket.Id,
                TotalPrice = basket.TotalPrice,
                EmailAddress = "sean@mail.com"
            };
            serviceOrder.CreateOrder(newOrder2);

            // act
            var orders = serviceOrder.GetOrders();

            // assert
            Assert.Equal(2, orders.Count);
        }

        [Fact]
        public void EditOrderShouldChangeOrderDetails()
        {
            // arrange
            var basket = serviceBasket.CreateBasket();
            Order newOrder = new Order
            {
                CustomerName = "sean",
                CustomerAddress = "address 1",
                Delivery = false,
                DeliveryDate = new DateTime(2021 / 12 / 25),
                CustBasketId = basket.Id,
                TotalPrice = basket.TotalPrice,
                EmailAddress = "sean@mail.com"
            };
            serviceOrder.CreateOrder(newOrder);
            // act
            newOrder.CustomerName = "David";
            newOrder.CustomerAddress = "Foxhill";
            newOrder.Delivery = true;
            newOrder.DeliveryDate = new DateTime(20010 / 04 / 14);

            serviceOrder.EditOrder(newOrder);

            // assert
            Assert.NotNull(newOrder);
            Assert.Equal("David", newOrder.CustomerName);
            Assert.Equal("Foxhill", newOrder.CustomerAddress);
            Assert.True(newOrder.Delivery);
            Assert.Equal(new DateTime(20010 / 04 / 14), newOrder.DeliveryDate);
        }

        [Fact]
        public void DeleteOrderShouldWork()
        {
            // arrange
            var basket = serviceBasket.CreateBasket();
            Order newOrder = new Order
            {
                CustomerName = "sean",
                CustomerAddress = "address 1",
                Delivery = false,
                DeliveryDate = new DateTime(2021 / 12 / 25),
                CustBasketId = basket.Id,
                TotalPrice = basket.TotalPrice,
                EmailAddress = "sean@mail.com"
            };
            serviceOrder.CreateOrder(newOrder);
            // act
            var deleted = serviceOrder.DeleteOrder(newOrder.Id);
            var orders = serviceOrder.GetOrders();

            // assert
            Assert.Equal(0, orders.Count);
        }

        [Fact]
        public void AddProductShouldAddToList()
        {
            // arrange
            var basket = serviceBasket.CreateBasket();
            var product = serviceProd.AddProduct("name", "description", "url.com", ProductType.Boxes,12, 15.00, 10);
            
            var order = serviceOrder.CreateOrder();

            // act
            var added = serviceOrder.AddBasketItem(order.Id, product.Id, 2, 15.00);
            added.Product = serviceProd.GetProduct(added.ProductId);
            var count = order.BasketItems.Count;

            // assert
            Assert.Equal(added.ProductId, added.Product.Id);
            Assert.Equal(1, count);
        }

        [Fact]
        public void OrderFulfillToggleShouldReturnTrue()
        {
            // arrange
            var basket = serviceBasket.CreateBasket();
            Order newOrder = new Order
            {
                CustomerName = "sean",
                CustomerAddress = "address 1",
                Delivery = false,
                DeliveryDate = new DateTime(2021 / 12 / 25),
                CustBasketId = basket.Id,
                TotalPrice = basket.TotalPrice,
                EmailAddress = "sean@mail.com"
            };
            serviceOrder.CreateOrder(newOrder);
            // act
            var fulfill = serviceOrder.OrderFulfillToggle(newOrder.Id);

            // assert
            Assert.True(fulfill);
        }

        [Fact]
        public void OrderFulfillToggleShouldReturnFalse()
        {
            // arrange
            var basket = serviceBasket.CreateBasket();
            Order newOrder = new Order
            {
                CustomerName = "sean",
                CustomerAddress = "address 1",
                Delivery = false,
                DeliveryDate = new DateTime(2021 / 12 / 25),
                CustBasketId = basket.Id,
                TotalPrice = basket.TotalPrice,
                EmailAddress = "sean@mail.com"
            };
            serviceOrder.CreateOrder(newOrder);
            // act
            var fulfillTrue = serviceOrder.OrderFulfillToggle(newOrder.Id);
            var fulfillFalse = serviceOrder.OrderFulfillToggle(newOrder.Id);

            // assert
            Assert.True(!fulfillFalse);
        }


    }
}
