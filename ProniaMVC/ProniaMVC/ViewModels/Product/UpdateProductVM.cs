﻿using System.ComponentModel.DataAnnotations;

namespace ProniaMVC.ViewModels
{
    public class UpdateProductVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Range(0.0, Double.MaxValue)]
        public double CostPrice { get; set; }
        [Range(0.0, Double.MaxValue)]
        public double SellPrice { get; set; }
        public string SKU { get; set; }
        public string Description { get; set; }
        [Range(0, 100)]
        public float Discount { get; set; }
        public List<int> ColorIds { get; set; }
        public List<int> SizeIds { get; set; }
        public List<int> CategoryIds { get; set; }
    }
}
