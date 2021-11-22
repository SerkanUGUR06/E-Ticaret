using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Product
    {
        public long ProductID { get; set; }
        [Required(ErrorMessage = "Please enter a product name")] 
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter a description")]
        public string Description { get; set; }
        [Required]
        [Range(0.01, double.MaxValue,ErrorMessage = "Please enter a positive price")]
        [Column(TypeName = "decimal(8, 2)")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Please specify a category")]
        public string Category { get; set; }

        [Required(ErrorMessage = "Please specify a main category")]
        public string MainCategory { get; set; }

        [Required(ErrorMessage = "Please specify a image")]
        public string ImgPath { get; set; }
    }
}
