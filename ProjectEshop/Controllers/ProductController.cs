using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectEshop.Models;
using ProjectEshop.Repository;
using System.Data.Entity;
using ProjectEshop.DTOs;

namespace ProjectEshop.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {

        #region private properties

        private readonly ILogger<ProductController> logger;
        private readonly EshopContext context;
        private readonly IRepository<Product> productRepository;

        #endregion

        #region ctor
        public ProductController(ILogger<ProductController> logger, EshopContext context, IRepository<Product> productRepository)
        {
            this.logger = logger;
            this.context = context;
            this.productRepository = productRepository;
        }
        #endregion

        #region public GET methods

        [HttpGet]
        [Route("ProductGetAll")]
        public IEnumerable<ProductDto> GetAllProducts()
        {
            var products = productRepository.Get(includeProperties:"IdCategoryNavigation,IdManufacturerNavigation,Scores").ToList();
            return products.Select(x => x.AdaptToDto()).ToList();
        }
        [HttpGet]
        [Route("ProductGetDetail")]
        public ActionResult<ProductDto> GetProductDetail(int id)
        {
            var result =
                    productRepository.GetById(id, includeProperties: "IdCategoryNavigation,IdManufacturerNavigation,Scores,ProductImages");
            return result.AdaptToDto();
        }
        #endregion

        #region public POST methods

        [HttpPost]
        [Route("ProductCreate")]
        public ActionResult<int> CreateProduct(ProductDto newProductDto)
        {
            var newProduct = newProductDto.AdaptToProduct();
            productRepository.Insert(newProduct);
            if (productRepository.Commit() < 1)
            {
                return Problem();
            }
            return newProduct.Id;
        }
        #endregion

        #region public PUT methods
        [HttpPut]
        [Route("ProductEdit")]
        public IActionResult EditProduct(ProductDto productEditDataDto)
        {
            var productEditData = productEditDataDto.AdaptToProduct();

            var productToEdit = productRepository.GetById(productEditData.Id, includeProperties: "ProductImages");
            productToEdit.ProductName = productEditData.ProductName;
            productToEdit.ProductDescription = productEditData.ProductDescription;
            productToEdit.ProductPrice = productEditData.ProductPrice;
            productToEdit.ProductWeight = productEditData.ProductWeight;
            productToEdit.ProductQuantityInStock = productEditData.ProductQuantityInStock;
            productToEdit.IdCategory = productEditData.IdCategory;
            productToEdit.IdManufacturer = productEditData.IdManufacturer;
            productToEdit.ProductImages = productEditData.ProductImages;
            if (productRepository.Commit() < 1)
            {
                return Problem();
            }
            return Ok();
        }
        #endregion


        #region public delete methods

        [HttpDelete]
        [Route("ProductDelete")]
        public IActionResult DeleteProduct(int id)
        {
            productRepository.Delete(id);
            if (productRepository.Commit() < 1)
            {
                return Problem();
            }
            return Ok();
        }
        #endregion

    }
}
