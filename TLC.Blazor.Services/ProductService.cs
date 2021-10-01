using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TLC.Blazor.Services.Interfaces;
using TLC.Data.Models;
using TLC.Data.Services.Interfaces;
using TLC.Core.Security;
using TLC.Core.Models;
using Microsoft.AspNetCore.Authorization;

namespace TLC.Blazor.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductServiceDb svc;

        public ProductService(IProductServiceDb svc)
        {
            this.svc = svc;
        }
       // [Authorize(Roles = "admin,manager")]
        public Product AddProduct(string name, string description, string imageUrl, ProductType productType, int pieces, double price, int limit)
        {
            return svc.AddProduct( name,  description,  imageUrl,  productType, pieces,  price,  limit);
        }
       // [Authorize(Roles = "admin,manager")]
        public bool ArchiveProduct(int id)
        {
            return svc.ArchiveProduct(id);
        }
        public bool ReviveProduct(int id)
        {
            return svc.ReviveProduct(id);
        }
        public IList<Product> GetArchived()
        {
            return svc.GetArchived();
        }
        //  [Authorize(Roles = "admin,manager")]
        public Product CreateProduct(Product product)
        {
            return svc.CreateProduct(product);
        }
      //  [Authorize(Roles = "admin,manager")]
        public bool DeleteProduct(int id)
        {
            try
            {
                return svc.DeleteProduct(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine( ex.Message);
                return false;
            }
            
        }

        public IList<Note> GetNotes(int id)
        {
            return svc.GetNotes(id);
        }

        public Product GetProduct(int id)
        {
            return svc.GetProduct(id);
        }

        // productType should filter product list by productType
        public IList<Product> GetProducts()
        {
            return svc.GetProducts();
        }
        public IList<Product> GetProducts(ProductType productType)
        {
            return svc.GetProducts(productType);
        }

        public IEnumerable<Product> SearchProducts(string filter = null)
        {
            return svc.SearchProducts(filter);
        }
    }
}
