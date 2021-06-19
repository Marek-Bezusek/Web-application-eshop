using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEshop.Web
{
    public class ProjectEshopWebConfiguration
    {
        [Required]
        public string OpenWeatherApiUrl { get; set; }
    }
}