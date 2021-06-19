namespace ProjectEshop.DTOs
{
    public partial record ManufacturerLogoDto
    {
        public int Id { get; set; }
        public byte[] Logo { get; set; }
        public int IdManufacturer { get; set; }
    }
}