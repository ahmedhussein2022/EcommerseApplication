﻿using System.ComponentModel.DataAnnotations;

namespace EcommerseApplication.DTO
{
    public class ProductCetegorySubcategoryDTO
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public int? CategoryID { get; set; }
        public bool IsAvailable { get; set; }
        [Required]
        public int? DiscountID { get; set; }
        [Required]
        public int PartenerID { get; set; }
        [Required]
        public int? subcategoryID { get; set; }
        [Required]

        public int Quantity { get; set; }

    }
}