using ProjectEshop.DTOs;

namespace ProjectEshop.DTOs
{
    public partial record ProductImageDto
    {
        public int Id { get; set; }
        public byte[] Picture { get; set; }
        public int IdProduct { get; set; }
        public ProductDto IdProductNavigation { get; set; }
    }
}