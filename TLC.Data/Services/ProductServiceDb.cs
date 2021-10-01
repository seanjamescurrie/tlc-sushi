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
    public class ProductServiceDb : IProductServiceDb
    {

        private readonly DatabaseContext ctx;

        public ProductServiceDb()
        {
            ctx = new DatabaseContext();
        }

        public void Initialise()
        {
            ctx.Initialise();
        }

        // ------------------ User Related Operations ------------------------

        // retrieve list of Products
        public IList<Product> GetProducts()
        {
            
            return ctx.Products.Where(prod => prod.Archived == false)
                                .ToList();
        }
        public IList<Product> GetProducts(ProductType productType)
        {
            return ctx.Products.Where(prod => prod.ProductType == productType)
                                .Where(prod => prod.Archived == false)
                                .ToList();
        }

        // Retrive Product by Id 
        public Product GetProduct(int id)
        {
            return ctx.Products.FirstOrDefault(prod => prod.Id == id);
        }

        public Product CreateProduct(Product product)
        {
            if (product == null)
            {
                return null;
            }

            var newProduct = new Product
            {
                Name = product.Name,
                Description = product.Description,
                ImageUrl = product.ImageUrl,
                ProductType = product.ProductType,
                Pieces = product.Pieces,
                Price = product.Price,
                Limit = product.Limit
            };
            ctx.Products.Add(newProduct);
            ctx.SaveChanges();
            return newProduct; // return newly added Product
        }

        // Add a new Product
        public Product AddProduct(string name, string description, string imageUrl, ProductType productType, int pieces, double price, int limit)
        {
            var product = new Product
            {
                Name = name,
                Description = description,
                ImageUrl = imageUrl,
                ProductType = productType,
                Pieces = pieces,
                Price = price,
                Limit = limit
            };
            ctx.Products.Add(product);
            ctx.SaveChanges();
            return product; // return newly added Product
        }

        // Delete the Product identified by Id returning true if deleted and false if not found
        public bool DeleteProduct(int id)
        {
            var prod = GetProduct(id);
            if (prod == null)
            {
                return false;
            }
            ctx.Products.Remove(prod);
            ctx.SaveChanges();
            return true;
        }

        //-------- Archiving Product Services

        public bool ArchiveProduct(int id)
        {
            var prod = GetProduct(id);
            if (prod == null)
            {
                return false;
            }
            prod.Archived = true;
            prod.DateArchived = DateTime.Today;

            var addedNote = new Note { SellingNotes = "" };
            prod.Notes.Add(addedNote);
            ctx.SaveChanges();
            return true;
        }

        public bool ReviveProduct(int id)
        {
            var prod = GetProduct(id);
            if (prod == null)
            {
                return false;
            }
            prod.Archived = false;

            ctx.SaveChanges();
            return true;
        }

        public IList<Product> GetArchived()
        {
            return ctx.Products.Where(prod => prod.Archived == true).ToList();
        }

        public IList<Note> GetNotes(int id)
        {
            var prod = GetProduct(id);
            return prod.Notes.ToList();
        }

        //-------- Search Services

        public IEnumerable<Product> SearchProducts(string filter = null)
        {
            IEnumerable<Product> products = GetProducts();

            if (string.IsNullOrWhiteSpace(filter))
            {
                return products;
            }

            return products.Where(x => x.Description
                            .ToLower()
                            .Contains(filter.ToLower()));
        }

    }
}
