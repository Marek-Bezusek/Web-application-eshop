using System.Collections.Generic;
using ProjectEshop.DTOs;

namespace ProjectEshop.DTOs
{
    public partial record ManufacturerDto
    {
        public int Id { get; set; }
        public string ManufacturerName { get; set; }
        public string Description { get; set; }
        public string Country { get; set; }
        public ICollection<ManufacturerLogoDto> ManufacturerLogos { get; set; }
        public ICollection<ProductDto> Products { get; set; }
    }
}