using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectEshop.DTOs;
using ProjectEshop.Models;
using ProjectEshop.Repository;

namespace ProjectEshop.Controllers
{
    [ApiController]
    [Route("api")]
    public class SearchController : ControllerBase
    {
        private readonly ILogger<SearchController> logger;
        private readonly EshopContext context;
        private readonly IRepository<Product> productRepository;
        private readonly IRepository<Manufacturer> manufacturerRepository;
        private readonly IRepository<Category> categoryRepository;
        private readonly IRepository<Score> scoreRepository;

        public SearchController(IRepository<Product> productRepository,
            IRepository<Manufacturer> manufacturerRepository, IRepository<Category> categoryRepository,
            ILogger<SearchController> logger, EshopContext context, IRepository<Score> scoreRepository)
        {
            this.manufacturerRepository = manufacturerRepository;
            this.context = context;
            this.productRepository = productRepository;
            this.logger = logger;
            this.categoryRepository = categoryRepository;
            this.scoreRepository = scoreRepository;
        }

        [HttpGet]
        [Route("Search")]
        public ActionResult<SearchModelDto> Search(string text)
        {
            var textLower = text.ToLower();
            var result = new SearchModel()
            {
                manufacturers = manufacturerRepository.Get(x =>
                    x.ManufacturerName.ToLower().Contains(textLower) ||
                    x.Country.ToLower().Contains(textLower) ||
                    x.Description.ToLower().Contains(textLower)).ToList(),


                products = productRepository.Get(x =>
                    x.ProductName.ToLower().Contains(textLower) ||
                    x.ProductDescription.ToLower().Contains(textLower)).ToList(),

                categories = categoryRepository.Get(x => x.CategoryName.ToLower().Contains(textLower)).ToList(),

                scores = scoreRepository.Get(x => x.TextScore.ToLower().Contains(textLower)).ToList()
            };

            return result.AdaptToDto();
        }

    }


}