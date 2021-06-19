﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectEshop.Models
{
    public class SearchModel
    {
        public List<Manufacturer> manufacturers { get; set; }
        public List<Product> products { get; set; }
        public List<Category> categories { get; set; }
        public List<Score> scores { get; set; }
    }
}
