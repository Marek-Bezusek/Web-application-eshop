using ProjectEshop.Interfaces;
using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectEshop.Models
{
    public partial class Score : IHasId
    {
        public int Id { get; set; }
        public int NumberScore { get; set; }
        public string TextScore { get; set; }
        public int IdProduct { get; set; }

        public virtual Product IdProductNavigation { get; set; }
    }
}
