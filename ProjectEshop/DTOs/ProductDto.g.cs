using System.Collections.Generic;
using ProjectEshop.DTOs;

namespace ProjectEshop.DTOs
{
    public partial record ProductDto
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public double ProductPrice { get; set; }
        public double ProductWeight { get; set; }
        public int ProductQuantityInStock { get; set; }
        public int IdCategory { get; set; }
        public int IdManufacturer { get; set; }
        public CategoryDto IdCategoryNavigation { get; set; }
        public ManufacturerDto IdManufacturerNavigation { get; set; }
        public ICollection<ProductImageDto> ProductImages { get; set; }
        public ICollection<ScoreDto> Scores { get; set; }
    }
}