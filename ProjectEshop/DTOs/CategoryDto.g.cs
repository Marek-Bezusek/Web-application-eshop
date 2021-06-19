using System.Collections.Generic;
using ProjectEshop.DTOs;

namespace ProjectEshop.DTOs
{
    public partial record CategoryDto
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public ICollection<ProductDto> Products { get; set; }
    }
}