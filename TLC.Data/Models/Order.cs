using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TLC.Data.Models
{
    public class Order
    {
        /*public Order()
        {
            LineItems = new List<OrderLineItem>();
        }*/

        public int Id { get; set; }

        // throws exception when pulling order confirm form
        // SQLite Error 19: 'NOT NULL constraint failed: Orders.CustomerName'
        [Required(ErrorMessage = "*Please enter your name.")]
        [StringLength(25, ErrorMessage = "*Name is too long.")]
        public string CustomerName { get; set; }

        [Required(ErrorMessage = "*Please enter your address.")]
        [StringLength(50, ErrorMessage = "*Address is too long.")]
        public string CustomerAddress { get; set; }

        [Required(ErrorMessage = "*Please enter your email.")]
        [EmailAddress(ErrorMessage = "Enter valid email address.")]
        public string EmailAddress { get; set; }

        [Required]
        public bool Delivery { get; set; }

        public DateTime? DatePlaced { get; set; } = DateTime.Now;

        [Required]
        //[Range(typeof(DateTime), minimum: "date", maximum: "date", ErrorMessage = "Value for {0} must be between {1} and {2}")]
        public DateTime DeliveryDate { get; set; } = DateTime.Now;
 
        public bool Fulfilled { get; set; } = false;

        public int CustBasketId { get; set; }

        // list of basketItems(products) for each order
        public List<BasketItem> BasketItems { get; set; } = new List<BasketItem>();
        
        public double TotalPrice { get; set; }

        public bool CardPayment { get; set; } = false;

        

    }
}
