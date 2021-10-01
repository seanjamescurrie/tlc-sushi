using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TLC.Core.Models;

namespace TLC.Data.Models
{
    public class Basket
    {
        public int Id { get; set; }
        public List<BasketItem> BasketItems { get; set; } = new List<BasketItem>();
        public User User { get; set; }
        public double TotalPrice { get; set; }
    }
}

