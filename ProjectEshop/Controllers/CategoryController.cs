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
    public class CategoryController : ControllerBase
    {
        private readonly ILogger<SearchController> logger;
        private readonly EshopContext context;
        private readonly IRepository<Product> productRepository;
        private readonly IRepository<Manufacturer> manufacturerRepository;
        private readonly IRepository<Category> categoryRepository;
        private readonly IRepository<Score> scoreRepository;

        public CategoryController(IRepository<Product> productRepository,
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
        [Route("CategoryGetAll")]
        public ActionResult<List<CategoryDto>> GetAll()
        {
            
            var result = categoryRepository.Get();
            var dtoResult = result.Select(x => x.AdaptToDto()).ToList();
            return dtoResult;
        }

    }


}