using CleanArch.Domain.Entities;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CleanArch.Application.DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }

        //data annotations
        [Required(ErrorMessage = "Product name is required")]
        [MinLength(3, ErrorMessage = "Product name must be at least 3 characters long")]
        [MaxLength(100, ErrorMessage = "Product name must not exceed 100 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The description is required")]
        [MinLength(5, ErrorMessage = "The description must be at least 5 characters long")]
        [MaxLength(200, ErrorMessage = "The description must not exceed 200 characters")]
        public string Description { get; set; }


        [Required(ErrorMessage = "The price is required")]
        [Range(1, 10000, ErrorMessage = "The price must be between 1 and 10,000")]
        public decimal Price { get; set; }
        public int Stock { get; set; }

        [MaxLength(250, ErrorMessage = "The image URL must not exceed 250 characters")]
        [DisplayName("Product Image")]
        public string Image { get; set; }
        public Category Category { get; set; }

        [DisplayName("Categories")]
        public int CategoryId { get; set; }
    }
}
