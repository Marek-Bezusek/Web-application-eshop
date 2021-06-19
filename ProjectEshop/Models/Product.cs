using ProjectEshop.Interfaces;
using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectEshop.Models
{
    public partial class Product : IHasId
    {
        public Product()
        {
            ProductImages = new HashSet<ProductImage>();
            Scores = new HashSet<Score>();
        }

        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public double ProductPrice { get; set; }
        public double ProductWeight { get; set; }
        public int ProductQuantityInStock { get; set; }
        public int IdCategory { get; set; }
        public int IdManufacturer { get; set; }

        public virtual Category IdCategoryNavigation { get; set; }
        public virtual Manufacturer IdManufacturerNavigation { get; set; }
        public virtual ICollection<ProductImage> ProductImages { get; set; }
        public virtual ICollection<Score> Scores { get; set; }
    }
}
