using System.Collections.Generic;
using Mapster;
using Mapster.Utils;
using ProjectEshop.DTOs;
using ProjectEshop.Models;

namespace ProjectEshop.DTOs
{
    public static partial class CategoryMapper
    {
        public static Category AdaptToCategory(this CategoryDto p1)
        {
            if (p1 == null)
            {
                return null;
            }
            MapContextScope scope = new MapContextScope();
            
            try
            {
                object cache;
                
                Dictionary<ReferenceTuple, object> references = scope.Context.References;
                ReferenceTuple key = new ReferenceTuple(p1, typeof(Category));
                
                if (references.TryGetValue(key, out cache))
                {
                    return (Category)cache;
                }
                Category result = new Category();
                references[key] = (object)result;
                
                result.Id = p1.Id;
                
                if (p1.CategoryName != null)
                {
                    result.CategoryName = p1.CategoryName;
                }
                
                if (p1.Products != null)
                {
                    result.Products = funcMain1(p1.Products);
                }
                return result;
            }
            finally
            {
                scope.Dispose();
            }
            
        }
        public static CategoryDto AdaptToDto(this Category p4)
        {
            if (p4 == null)
            {
                return null;
            }
            MapContextScope scope = new MapContextScope();
            
            try
            {
                object cache;
                
                Dictionary<ReferenceTuple, object> references = scope.Context.References;
                ReferenceTuple key = new ReferenceTuple(p4, typeof(CategoryDto));
                
                if (references.TryGetValue(key, out cache))
                {
                    return (CategoryDto)cache;
                }
                CategoryDto result = new CategoryDto();
                references[key] = (object)result;
                
                result.Id = p4.Id;
                
                if (p4.CategoryName != null)
                {
                    result.CategoryName = p4.CategoryName;
                }
                
                if (p4.Products != null)
                {
                    result.Products = funcMain3(p4.Products);
                }
                return result;
            }
            finally
            {
                scope.Dispose();
            }
            
        }
        
        private static ICollection<Product> funcMain1(ICollection<ProductDto> p2)
        {
            if (p2 == null)
            {
                return null;
            }
            ICollection<Product> result = new List<Product>(p2.Count);
            
            IEnumerator<ProductDto> enumerator = p2.GetEnumerator();
            
            while (enumerator.MoveNext())
            {
                ProductDto item = enumerator.Current;
                result.Add(funcMain2(item));
            }
            return result;
            
        }
        
        private static ICollection<ProductDto> funcMain3(ICollection<Product> p5)
        {
            if (p5 == null)
            {
                return null;
            }
            ICollection<ProductDto> result = new List<ProductDto>(p5.Count);
            
            IEnumerator<Product> enumerator = p5.GetEnumerator();
            
            while (enumerator.MoveNext())
            {
                Product item = enumerator.Current;
                result.Add(funcMain4(item));
            }
            return result;
            
        }
        
        private static Product funcMain2(ProductDto p3)
        {
            if (p3 == null)
            {
                return null;
            }
            MapContextScope scope = new MapContextScope();
            
            try
            {
                object cache;
                
                Dictionary<ReferenceTuple, object> references = scope.Context.References;
                ReferenceTuple key = new ReferenceTuple(p3, typeof(Product));
                
                if (references.TryGetValue(key, out cache))
                {
                    return (Product)cache;
                }
                Product result = new Product();
                references[key] = (object)result;
                
                result.Id = p3.Id;
                
                if (p3.ProductName != null)
                {
                    result.ProductName = p3.ProductName;
                }
                
                if (p3.ProductDescription != null)
                {
                    result.ProductDescription = p3.ProductDescription;
                }
                result.ProductPrice = p3.ProductPrice;
                result.ProductWeight = p3.ProductWeight;
                result.ProductQuantityInStock = p3.ProductQuantityInStock;
                result.IdCategory = p3.IdCategory;
                result.IdManufacturer = p3.IdManufacturer;
                
                if (p3.IdCategoryNavigation != null)
                {
                    result.IdCategoryNavigation = null;
                }
                
                if (p3.IdManufacturerNavigation != null)
                {
                    result.IdManufacturerNavigation = null;
                }
                
                if (p3.ProductImages != null)
                {
                    result.ProductImages = null;
                }
                
                if (p3.Scores != null)
                {
                    result.Scores = null;
                }
                return result;
            }
            finally
            {
                scope.Dispose();
            }
            
        }
        
        private static ProductDto funcMain4(Product p6)
        {
            if (p6 == null)
            {
                return null;
            }
            MapContextScope scope = new MapContextScope();
            
            try
            {
                object cache;
                
                Dictionary<ReferenceTuple, object> references = scope.Context.References;
                ReferenceTuple key = new ReferenceTuple(p6, typeof(ProductDto));
                
                if (references.TryGetValue(key, out cache))
                {
                    return (ProductDto)cache;
                }
                ProductDto result = new ProductDto();
                references[key] = (object)result;
                
                result.Id = p6.Id;
                
                if (p6.ProductName != null)
                {
                    result.ProductName = p6.ProductName;
                }
                
                if (p6.ProductDescription != null)
                {
                    result.ProductDescription = p6.ProductDescription;
                }
                result.ProductPrice = p6.ProductPrice;
                result.ProductWeight = p6.ProductWeight;
                result.ProductQuantityInStock = p6.ProductQuantityInStock;
                result.IdCategory = p6.IdCategory;
                result.IdManufacturer = p6.IdManufacturer;
                
                if (p6.IdCategoryNavigation != null)
                {
                    result.IdCategoryNavigation = null;
                }
                
                if (p6.IdManufacturerNavigation != null)
                {
                    result.IdManufacturerNavigation = null;
                }
                
                if (p6.ProductImages != null)
                {
                    result.ProductImages = null;
                }
                
                if (p6.Scores != null)
                {
                    result.Scores = null;
                }
                return result;
            }
            finally
            {
                scope.Dispose();
            }
            
        }
    }
}