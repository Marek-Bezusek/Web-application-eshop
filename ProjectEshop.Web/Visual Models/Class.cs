using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectEshop.Web.ApiClients

{
    public partial class ProductDto
    {
        [JsonIgnore]
        public float Average
        {
            get
            {
                if (this.Scores.Count < 1) return 0;

                    return (float)this.Scores.Average(x => x.NumberScore);
            }
        }
    }

}