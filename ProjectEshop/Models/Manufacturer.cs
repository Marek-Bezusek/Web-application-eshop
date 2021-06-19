using Mapster;
using ProjectEshop.Interfaces;
using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectEshop.Models
{
    
    public partial class Manufacturer : IHasId
    {
        public Manufacturer()
        {
            ManufacturerLogos = new HashSet<ManufacturerLogo>();
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string ManufacturerName { get; set; }
        public string Description { get; set; }
        public string Country { get; set; }

        public virtual ICollection<ManufacturerLogo> ManufacturerLogos { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
