﻿using System.ComponentModel.DataAnnotations;

namespace productsApp.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Price is required.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than 0.")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Count is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Count must be at least 1.")]
        public int Count { get; set; }

        [Required(ErrorMessage = "Description is required.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "CategoryId is required.")]
        public int CategoryId { get; set; } // Yeni əlavə olunmuş sahə
    }
}
