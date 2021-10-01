using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TLC.Data.Models;

namespace TLC.Blazor.Services.Interfaces
{
    public interface IProductService
    {

        // ---------------- Product Management --------------
        IList<Product> GetProducts();
        IList<Product> GetProducts(ProductType productType);
        Product GetProduct(int id);
        Product CreateProduct(Product product);
        Product AddProduct(string name, string description, string imageUrl, ProductType productType, int pieces, double price, int limit);

        bool DeleteProduct(int id);

        //------ Archive Services

        bool ArchiveProduct(int id);
        bool ReviveProduct(int id);
        IList<Product> GetArchived();
        IList<Note> GetNotes(int id);

        IEnumerable<Product> SearchProducts(string filter = null);
    }
}
