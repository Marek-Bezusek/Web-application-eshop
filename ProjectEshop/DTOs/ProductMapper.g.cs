using System.Collections.Generic;
using Mapster;
using Mapster.Utils;
using ProjectEshop.DTOs;
using ProjectEshop.Models;

namespace ProjectEshop.DTOs
{
    public static partial class ProductMapper
    {
        public static Product AdaptToProduct(this ProductDto p1)
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
                ReferenceTuple key = new ReferenceTuple(p1, typeof(Product));
                
                if (references.TryGetValue(key, out cache))
                {
                    return (Product)cache;
                }
                Product result = new Product();
                references[key] = (object)result;
                
                result.Id = p1.Id;
                
                if (p1.ProductName != null)
                {
                    result.ProductName = p1.ProductName;
                }
                
                if (p1.ProductDescription != null)
                {
                    result.ProductDescription = p1.ProductDescription;
                }
                result.ProductPrice = p1.ProductPrice;
                result.ProductWeight = p1.ProductWeight;
                result.ProductQuantityInStock = p1.ProductQuantityInStock;
                result.IdCategory = p1.IdCategory;
                result.IdManufacturer = p1.IdManufacturer;
                
                if (p1.IdCategoryNavigation != null)
                {
                    result.IdCategoryNavigation = funcMain1(p1.IdCategoryNavigation);
                }
                
                if (p1.IdManufacturerNavigation != null)
                {
                    result.IdManufacturerNavigation = funcMain2(p1.IdManufacturerNavigation);
                }
                
                if (p1.ProductImages != null)
                {
                    result.ProductImages = funcMain3(p1.ProductImages);
                }
                
                if (p1.Scores != null)
                {
                    result.Scores = funcMain5(p1.Scores);
                }
                return result;
            }
            finally
            {
                scope.Dispose();
            }
            
        }
        public static ProductDto AdaptToDto(this Product p8)
        {
            if (p8 == null)
            {
                return null;
            }
            MapContextScope scope = new MapContextScope();
            
            try
            {
                object cache;
                
                Dictionary<ReferenceTuple, object> references = scope.Context.References;
                ReferenceTuple key = new ReferenceTuple(p8, typeof(ProductDto));
                
                if (references.TryGetValue(key, out cache))
                {
                    return (ProductDto)cache;
                }
                ProductDto result = new ProductDto();
                references[key] = (object)result;
                
                result.Id = p8.Id;
                
                if (p8.ProductName != null)
                {
                    result.ProductName = p8.ProductName;
                }
                
                if (p8.ProductDescription != null)
                {
                    result.ProductDescription = p8.ProductDescription;
                }
                result.ProductPrice = p8.ProductPrice;
                result.ProductWeight = p8.ProductWeight;
                result.ProductQuantityInStock = p8.ProductQuantityInStock;
                result.IdCategory = p8.IdCategory;
                result.IdManufacturer = p8.IdManufacturer;
                
                if (p8.IdCategoryNavigation != null)
                {
                    result.IdCategoryNavigation = funcMain7(p8.IdCategoryNavigation);
                }
                
                if (p8.IdManufacturerNavigation != null)
                {
                    result.IdManufacturerNavigation = funcMain8(p8.IdManufacturerNavigation);
                }
                
                if (p8.ProductImages != null)
                {
                    result.ProductImages = funcMain9(p8.ProductImages);
                }
                
                if (p8.Scores != null)
                {
                    result.Scores = funcMain11(p8.Scores);
                }
                return result;
            }
            finally
            {
                scope.Dispose();
            }
            
        }
        
        private static Category funcMain1(CategoryDto p2)
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
                ReferenceTuple key = new ReferenceTuple(p2, typeof(Category));
                
                if (references.TryGetValue(key, out cache))
                {
                    return (Category)cache;
                }
                Category result = new Category();
                references[key] = (object)result;
                
                result.Id = p2.Id;
                
                if (p2.CategoryName != null)
                {
                    result.CategoryName = p2.CategoryName;
                }
                
                if (p2.Products != null)
                {
                    result.Products = null;
                }
                return result;
            }
            finally
            {
                scope.Dispose();
            }
            
        }
        
        private static Manufacturer funcMain2(ManufacturerDto p3)
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
                ReferenceTuple key = new ReferenceTuple(p3, typeof(Manufacturer));
                
                if (references.TryGetValue(key, out cache))
                {
                    return (Manufacturer)cache;
                }
                Manufacturer result = new Manufacturer();
                references[key] = (object)result;
                
                result.Id = p3.Id;
                
                if (p3.ManufacturerName != null)
                {
                    result.ManufacturerName = p3.ManufacturerName;
                }
                
                if (p3.Description != null)
                {
                    result.Description = p3.Description;
                }
                
                if (p3.Country != null)
                {
                    result.Country = p3.Country;
                }
                
                if (p3.ManufacturerLogos != null)
                {
                    result.ManufacturerLogos = null;
                }
                
                if (p3.Products != null)
                {
                    result.Products = null;
                }
                return result;
            }
            finally
            {
                scope.Dispose();
            }
            
        }
        
        private static ICollection<ProductImage> funcMain3(ICollection<ProductImageDto> p4)
        {
            if (p4 == null)
            {
                return null;
            }
            ICollection<ProductImage> result = new List<ProductImage>(p4.Count);
            
            IEnumerator<ProductImageDto> enumerator = p4.GetEnumerator();
            
            while (enumerator.MoveNext())
            {
                ProductImageDto item = enumerator.Current;
                result.Add(funcMain4(item));
            }
            return result;
            
        }
        
        private static ICollection<Score> funcMain5(ICollection<ScoreDto> p6)
        {
            if (p6 == null)
            {
                return null;
            }
            ICollection<Score> result = new List<Score>(p6.Count);
            
            IEnumerator<ScoreDto> enumerator = p6.GetEnumerator();
            
            while (enumerator.MoveNext())
            {
                ScoreDto item = enumerator.Current;
                result.Add(funcMain6(item));
            }
            return result;
            
        }
        
        private static CategoryDto funcMain7(Category p9)
        {
            if (p9 == null)
            {
                return null;
            }
            MapContextScope scope = new MapContextScope();
            
            try
            {
                object cache;
                
                Dictionary<ReferenceTuple, object> references = scope.Context.References;
                ReferenceTuple key = new ReferenceTuple(p9, typeof(CategoryDto));
                
                if (references.TryGetValue(key, out cache))
                {
                    return (CategoryDto)cache;
                }
                CategoryDto result = new CategoryDto();
                references[key] = (object)result;
                
                result.Id = p9.Id;
                
                if (p9.CategoryName != null)
                {
                    result.CategoryName = p9.CategoryName;
                }
                
                if (p9.Products != null)
                {
                    result.Products = null;
                }
                return result;
            }
            finally
            {
                scope.Dispose();
            }
            
        }
        
        private static ManufacturerDto funcMain8(Manufacturer p10)
        {
            if (p10 == null)
            {
                return null;
            }
            MapContextScope scope = new MapContextScope();
            
            try
            {
                object cache;
                
                Dictionary<ReferenceTuple, object> references = scope.Context.References;
                ReferenceTuple key = new ReferenceTuple(p10, typeof(ManufacturerDto));
                
                if (references.TryGetValue(key, out cache))
                {
                    return (ManufacturerDto)cache;
                }
                ManufacturerDto result = new ManufacturerDto();
                references[key] = (object)result;
                
                result.Id = p10.Id;
                
                if (p10.ManufacturerName != null)
                {
                    result.ManufacturerName = p10.ManufacturerName;
                }
                
                if (p10.Description != null)
                {
                    result.Description = p10.Description;
                }
                
                if (p10.Country != null)
                {
                    result.Country = p10.Country;
                }
                
                if (p10.ManufacturerLogos != null)
                {
                    result.ManufacturerLogos = null;
                }
                
                if (p10.Products != null)
                {
                    result.Products = null;
                }
                return result;
            }
            finally
            {
                scope.Dispose();
            }
            
        }
        
        private static ICollection<ProductImageDto> funcMain9(ICollection<ProductImage> p11)
        {
            if (p11 == null)
            {
                return null;
            }
            ICollection<ProductImageDto> result = new List<ProductImageDto>(p11.Count);
            
            IEnumerator<ProductImage> enumerator = p11.GetEnumerator();
            
            while (enumerator.MoveNext())
            {
                ProductImage item = enumerator.Current;
                result.Add(funcMain10(item));
            }
            return result;
            
        }
        
        private static ICollection<ScoreDto> funcMain11(ICollection<Score> p13)
        {
            if (p13 == null)
            {
                return null;
            }
            ICollection<ScoreDto> result = new List<ScoreDto>(p13.Count);
            
            IEnumerator<Score> enumerator = p13.GetEnumerator();
            
            while (enumerator.MoveNext())
            {
                Score item = enumerator.Current;
                result.Add(funcMain12(item));
            }
            return result;
            
        }
        
        private static ProductImage funcMain4(ProductImageDto p5)
        {
            if (p5 == null)
            {
                return null;
            }
            MapContextScope scope = new MapContextScope();
            
            try
            {
                object cache;
                
                Dictionary<ReferenceTuple, object> references = scope.Context.References;
                ReferenceTuple key = new ReferenceTuple(p5, typeof(ProductImage));
                
                if (references.TryGetValue(key, out cache))
                {
                    return (ProductImage)cache;
                }
                ProductImage result = new ProductImage();
                references[key] = (object)result;
                
                result.Id = p5.Id;
                
                if (p5.Picture != null)
                {
                    result.Picture = p5.Picture;
                }
                result.IdProduct = p5.IdProduct;
                
                if (p5.IdProductNavigation != null)
                {
                    result.IdProductNavigation = null;
                }
                return result;
            }
            finally
            {
                scope.Dispose();
            }
            
        }
        
        private static Score funcMain6(ScoreDto p7)
        {
            if (p7 == null)
            {
                return null;
            }
            MapContextScope scope = new MapContextScope();
            
            try
            {
                object cache;
                
                Dictionary<ReferenceTuple, object> references = scope.Context.References;
                ReferenceTuple key = new ReferenceTuple(p7, typeof(Score));
                
                if (references.TryGetValue(key, out cache))
                {
                    return (Score)cache;
                }
                Score result = new Score();
                references[key] = (object)result;
                
                result.Id = p7.Id;
                result.NumberScore = p7.NumberScore;
                
                if (p7.TextScore != null)
                {
                    result.TextScore = p7.TextScore;
                }
                result.IdProduct = p7.IdProduct;
                
                if (p7.IdProductNavigation != null)
                {
                    result.IdProductNavigation = null;
                }
                return result;
            }
            finally
            {
                scope.Dispose();
            }
            
        }
        
        private static ProductImageDto funcMain10(ProductImage p12)
        {
            if (p12 == null)
            {
                return null;
            }
            MapContextScope scope = new MapContextScope();
            
            try
            {
                object cache;
                
                Dictionary<ReferenceTuple, object> references = scope.Context.References;
                ReferenceTuple key = new ReferenceTuple(p12, typeof(ProductImageDto));
                
                if (references.TryGetValue(key, out cache))
                {
                    return (ProductImageDto)cache;
                }
                ProductImageDto result = new ProductImageDto();
                references[key] = (object)result;
                
                result.Id = p12.Id;
                
                if (p12.Picture != null)
                {
                    result.Picture = p12.Picture;
                }
                result.IdProduct = p12.IdProduct;
                
                if (p12.IdProductNavigation != null)
                {
                    result.IdProductNavigation = null;
                }
                return result;
            }
            finally
            {
                scope.Dispose();
            }
            
        }
        
        private static ScoreDto funcMain12(Score p14)
        {
            if (p14 == null)
            {
                return null;
            }
            MapContextScope scope = new MapContextScope();
            
            try
            {
                object cache;
                
                Dictionary<ReferenceTuple, object> references = scope.Context.References;
                ReferenceTuple key = new ReferenceTuple(p14, typeof(ScoreDto));
                
                if (references.TryGetValue(key, out cache))
                {
                    return (ScoreDto)cache;
                }
                ScoreDto result = new ScoreDto();
                references[key] = (object)result;
                
                result.Id = p14.Id;
                result.NumberScore = p14.NumberScore;
                
                if (p14.TextScore != null)
                {
                    result.TextScore = p14.TextScore;
                }
                result.IdProduct = p14.IdProduct;
                
                if (p14.IdProductNavigation != null)
                {
                    result.IdProductNavigation = null;
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