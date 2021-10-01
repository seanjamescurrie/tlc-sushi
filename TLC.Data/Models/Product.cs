using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TLC.Data.Models
{
    public enum ProductType
    {
        Boxes, IndividualRolls, PokeBowls, Sides, Sauces
    }

    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "*Please enter product name.")]
        [StringLength(25, ErrorMessage = "*Name is too long.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "*Please enter product Description.")]
        [StringLength(250, ErrorMessage = "*Description is too long.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "*Required.")]
        [Range(0, 50, ErrorMessage = "*Number is too high.")]
        public int Pieces { get; set; }

        // public List<ItemDescription> Items { get; set; } = new List<ItemDescription>();
        [Required]
        public ProductType ProductType { get; set; }

        [Required(ErrorMessage = "*Required.")]
        public double Price { get; set; }

        [Required(ErrorMessage = "*Required.")]
        public int Limit { get; set; }
        [Required(ErrorMessage = "*Please enter url.")]
        [Url(ErrorMessage = "*Please enter valid url")]
        public string ImageUrl { get; set; }

        public string Photo { get; set; }

        public int Sold { get; set; }

        //------------ Archiving Data Properties-------------
        public bool Archived { get; set; } = false;
        public DateTime DateArchived { get; set; }

        public List<Note> Notes { get; set; } = new List<Note>();
    }
}
