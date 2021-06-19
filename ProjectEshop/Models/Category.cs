using ProjectEshop.Interfaces;
using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectEshop.Models
{
    public partial class Category : IHasId
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
