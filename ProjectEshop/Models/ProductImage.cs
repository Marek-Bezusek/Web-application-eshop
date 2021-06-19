using ProjectEshop.Interfaces;
using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectEshop.Models
{
    public partial class ProductImage : IHasId
    {
        public int Id { get; set; }
        public byte[] Picture { get; set; }
        public int IdProduct { get; set; }

        public virtual Product IdProductNavigation { get; set; }
    }
}
