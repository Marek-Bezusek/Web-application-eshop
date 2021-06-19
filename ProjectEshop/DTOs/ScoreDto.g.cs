using ProjectEshop.DTOs;

namespace ProjectEshop.DTOs
{
    public partial record ScoreDto
    {
        public int Id { get; set; }
        public int NumberScore { get; set; }
        public string TextScore { get; set; }
        public int IdProduct { get; set; }
        public ProductDto IdProductNavigation { get; set; }
    }
}