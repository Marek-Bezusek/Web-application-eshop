using ProjectEshop.Interfaces;
using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectEshop.Models
{
    public partial class ManufacturerLogo : IHasId
    {
        public int Id { get; set; }
        public byte[] Logo { get; set; }
        public int IdManufacturer { get; set; }

        public virtual Manufacturer IdManufacturerNavigation { get; set; }
    }
}
