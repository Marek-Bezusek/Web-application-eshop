using System.Collections.Generic;
using Mapster;
using Mapster.Utils;
using ProjectEshop.DTOs;
using ProjectEshop.Models;

namespace ProjectEshop.DTOs
{
    public static partial class ProductImageMapper
    {
        public static ProductImage AdaptToProductImage(this ProductImageDto p1)
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
                ReferenceTuple key = new ReferenceTuple(p1, typeof(ProductImage));
                
                if (references.TryGetValue(key, out cache))
                {
                    return (ProductImage)cache;
                }
                ProductImage result = new ProductImage();
                references[key] = (object)result;
                
                result.Id = p1.Id;
                
                if (p1.Picture != null)
                {
                    result.Picture = p1.Picture;
                }
                result.IdProduct = p1.IdProduct;
                
                if (p1.IdProductNavigation != null)
                {
                    result.IdProductNavigation = funcMain1(p1.IdProductNavigation);
                }
                return result;
            }
            finally
            {
                scope.Dispose();
            }
            
        }
        public static ProductImageDto AdaptToDto(this ProductImage p3)
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
                ReferenceTuple key = new ReferenceTuple(p3, typeof(ProductImageDto));
                
                if (references.TryGetValue(key, out cache))
                {
                    return (ProductImageDto)cache;
                }
                ProductImageDto result = new ProductImageDto();
                references[key] = (object)result;
                
                result.Id = p3.Id;
                
                if (p3.Picture != null)
                {
                    result.Picture = p3.Picture;
                }
                result.IdProduct = p3.IdProduct;
                
                if (p3.IdProductNavigation != null)
                {
                    result.IdProductNavigation = funcMain2(p3.IdProductNavigation);
                }
                return result;
            }
            finally
            {
                scope.Dispose();
            }
            
        }
        
        private static Product funcMain1(ProductDto p2)
        {
            if (p2 == null)
            {
                return null;
            }
            MapContextScope scope = new MapContextScope();
            
            try
            {
                object cache;
                
                Dictionary<ReferenceTuple, object> references = scope.Context.References;
                ReferenceTuple key = new ReferenceTuple(p2, typeof(Product));
                
                if (references.TryGetValue(key, out cache))
                {
                    return (Product)cache;
                }
                Product result = new Product();
                references[key] = (object)result;
                
                result.Id = p2.Id;
                
                if (p2.ProductName != null)
                {
                    result.ProductName = p2.ProductName;
                }
                
                if (p2.ProductDescription != null)
                {
                    result.ProductDescription = p2.ProductDescription;
                }
                result.ProductPrice = p2.ProductPrice;
                result.ProductWeight = p2.ProductWeight;
                result.ProductQuantityInStock = p2.ProductQuantityInStock;
                result.IdCategory = p2.IdCategory;
                result.IdManufacturer = p2.IdManufacturer;
                
                if (p2.IdCategoryNavigation != null)
                {
                    result.IdCategoryNavigation = null;
                }
                
                if (p2.IdManufacturerNavigation != null)
                {
                    result.IdManufacturerNavigation = null;
                }
                
                if (p2.ProductImages != null)
                {
                    result.ProductImages = null;
                }
                
                if (p2.Scores != null)
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
        
        private static ProductDto funcMain2(Product p4)
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
                ReferenceTuple key = new ReferenceTuple(p4, typeof(ProductDto));
                
                if (references.TryGetValue(key, out cache))
                {
                    return (ProductDto)cache;
                }
                ProductDto result = new ProductDto();
                references[key] = (object)result;
                
                result.Id = p4.Id;
                
                if (p4.ProductName != null)
                {
                    result.ProductName = p4.ProductName;
                }
                
                if (p4.ProductDescription != null)
                {
                    result.ProductDescription = p4.ProductDescription;
                }
                result.ProductPrice = p4.ProductPrice;
                result.ProductWeight = p4.ProductWeight;
                result.ProductQuantityInStock = p4.ProductQuantityInStock;
                result.IdCategory = p4.IdCategory;
                result.IdManufacturer = p4.IdManufacturer;
                
                if (p4.IdCategoryNavigation != null)
                {
                    result.IdCategoryNavigation = null;
                }
                
                if (p4.IdManufacturerNavigation != null)
                {
                    result.IdManufacturerNavigation = null;
                }
                
                if (p4.ProductImages != null)
                {
                    result.ProductImages = null;
                }
                
                if (p4.Scores != null)
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