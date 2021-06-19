using System.Collections.Generic;
using ProjectEshop.DTOs;

namespace ProjectEshop.DTOs
{
    public partial record SearchModelDto
    {
        public List<ManufacturerDto> manufacturers { get; set; }
        public List<ProductDto> products { get; set; }
        public List<CategoryDto> categories { get; set; }
        public List<ScoreDto> scores { get; set; }
    }
}