using System.Collections.Generic;
using Mapster;
using Mapster.Utils;
using ProjectEshop.DTOs;
using ProjectEshop.Models;

namespace ProjectEshop.DTOs
{
    public static partial class SearchModelMapper
    {
        public static SearchModel AdaptToSearchModel(this SearchModelDto p1)
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
                ReferenceTuple key = new ReferenceTuple(p1, typeof(SearchModel));
                
                if (references.TryGetValue(key, out cache))
                {
                    return (SearchModel)cache;
                }
                SearchModel result = new SearchModel();
                references[key] = (object)result;
                
                if (p1.manufacturers != null)
                {
                    result.manufacturers = funcMain1(p1.manufacturers);
                }
                
                if (p1.products != null)
                {
                    result.products = funcMain3(p1.products);
                }
                
                if (p1.categories != null)
                {
                    result.categories = funcMain5(p1.categories);
                }
                
                if (p1.scores != null)
                {
                    result.scores = funcMain7(p1.scores);
                }
                return result;
            }
            finally
            {
                scope.Dispose();
            }
            
        }
        public static SearchModelDto AdaptToDto(this SearchModel p10)
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
                ReferenceTuple key = new ReferenceTuple(p10, typeof(SearchModelDto));
                
                if (references.TryGetValue(key, out cache))
                {
                    return (SearchModelDto)cache;
                }
                SearchModelDto result = new SearchModelDto();
                references[key] = (object)result;
                
                if (p10.manufacturers != null)
                {
                    result.manufacturers = funcMain9(p10.manufacturers);
                }
                
                if (p10.products != null)
                {
                    result.products = funcMain11(p10.products);
                }
                
                if (p10.categories != null)
                {
                    result.categories = funcMain13(p10.categories);
                }
                
                if (p10.scores != null)
                {
                    result.scores = funcMain15(p10.scores);
                }
                return result;
            }
            finally
            {
                scope.Dispose();
            }
            
        }
        
        private static List<Manufacturer> funcMain1(List<ManufacturerDto> p2)
        {
            if (p2 == null)
            {
                return null;
            }
            List<Manufacturer> result = new List<Manufacturer>(p2.Count);
            
            int i = 0;
            int len = p2.Count;
            
            while (i < len)
            {
                ManufacturerDto item = p2[i];
                result.Add(funcMain2(item));
                i++;
            }
            return result;
            
        }
        
        private static List<Product> funcMain3(List<ProductDto> p4)
        {
            if (p4 == null)
            {
                return null;
            }
            List<Product> result = new List<Product>(p4.Count);
            
            int i = 0;
            int len = p4.Count;
            
            while (i < len)
            {
                ProductDto item = p4[i];
                result.Add(funcMain4(item));
                i++;
            }
            return result;
            
        }
        
        private static List<Category> funcMain5(List<CategoryDto> p6)
        {
            if (p6 == null)
            {
                return null;
            }
            List<Category> result = new List<Category>(p6.Count);
            
            int i = 0;
            int len = p6.Count;
            
            while (i < len)
            {
                CategoryDto item = p6[i];
                result.Add(funcMain6(item));
                i++;
            }
            return result;
            
        }
        
        private static List<Score> funcMain7(List<ScoreDto> p8)
        {
            if (p8 == null)
            {
                return null;
            }
            List<Score> result = new List<Score>(p8.Count);
            
            int i = 0;
            int len = p8.Count;
            
            while (i < len)
            {
                ScoreDto item = p8[i];
                result.Add(funcMain8(item));
                i++;
            }
            return result;
            
        }
        
        private static List<ManufacturerDto> funcMain9(List<Manufacturer> p11)
        {
            if (p11 == null)
            {
                return null;
            }
            List<ManufacturerDto> result = new List<ManufacturerDto>(p11.Count);
            
            int i = 0;
            int len = p11.Count;
            
            while (i < len)
            {
                Manufacturer item = p11[i];
                result.Add(funcMain10(item));
                i++;
            }
            return result;
            
        }
        
        private static List<ProductDto> funcMain11(List<Product> p13)
        {
            if (p13 == null)
            {
                return null;
            }
            List<ProductDto> result = new List<ProductDto>(p13.Count);
            
            int i = 0;
            int len = p13.Count;
            
            while (i < len)
            {
                Product item = p13[i];
                result.Add(funcMain12(item));
                i++;
            }
            return result;
            
        }
        
        private static List<CategoryDto> funcMain13(List<Category> p15)
        {
            if (p15 == null)
            {
                return null;
            }
            List<CategoryDto> result = new List<CategoryDto>(p15.Count);
            
            int i = 0;
            int len = p15.Count;
            
            while (i < len)
            {
                Category item = p15[i];
                result.Add(funcMain14(item));
                i++;
            }
            return result;
            
        }
        
        private static List<ScoreDto> funcMain15(List<Score> p17)
        {
            if (p17 == null)
            {
                return null;
            }
            List<ScoreDto> result = new List<ScoreDto>(p17.Count);
            
            int i = 0;
            int len = p17.Count;
            
            while (i < len)
            {
                Score item = p17[i];
                result.Add(funcMain16(item));
                i++;
            }
            return result;
            
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
        
        private static Product funcMain4(ProductDto p5)
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
                ReferenceTuple key = new ReferenceTuple(p5, typeof(Product));
                
                if (references.TryGetValue(key, out cache))
                {
                    return (Product)cache;
                }
                Product result = new Product();
                references[key] = (object)result;
                
                result.Id = p5.Id;
                
                if (p5.ProductName != null)
                {
                    result.ProductName = p5.ProductName;
                }
                
                if (p5.ProductDescription != null)
                {
                    result.ProductDescription = p5.ProductDescription;
                }
                result.ProductPrice = p5.ProductPrice;
                result.ProductWeight = p5.ProductWeight;
                result.ProductQuantityInStock = p5.ProductQuantityInStock;
                result.IdCategory = p5.IdCategory;
                result.IdManufacturer = p5.IdManufacturer;
                
                if (p5.IdCategoryNavigation != null)
                {
                    result.IdCategoryNavigation = null;
                }
                
                if (p5.IdManufacturerNavigation != null)
                {
                    result.IdManufacturerNavigation = null;
                }
                
                if (p5.ProductImages != null)
                {
                    result.ProductImages = null;
                }
                
                if (p5.Scores != null)
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
        
        private static Category funcMain6(CategoryDto p7)
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
                ReferenceTuple key = new ReferenceTuple(p7, typeof(Category));
                
                if (references.TryGetValue(key, out cache))
                {
                    return (Category)cache;
                }
                Category result = new Category();
                references[key] = (object)result;
                
                result.Id = p7.Id;
                
                if (p7.CategoryName != null)
                {
                    result.CategoryName = p7.CategoryName;
                }
                
                if (p7.Products != null)
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
        
        private static Score funcMain8(ScoreDto p9)
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
                ReferenceTuple key = new ReferenceTuple(p9, typeof(Score));
                
                if (references.TryGetValue(key, out cache))
                {
                    return (Score)cache;
                }
                Score result = new Score();
                references[key] = (object)result;
                
                result.Id = p9.Id;
                result.NumberScore = p9.NumberScore;
                
                if (p9.TextScore != null)
                {
                    result.TextScore = p9.TextScore;
                }
                result.IdProduct = p9.IdProduct;
                
                if (p9.IdProductNavigation != null)
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
        
        private static ManufacturerDto funcMain10(Manufacturer p12)
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
                ReferenceTuple key = new ReferenceTuple(p12, typeof(ManufacturerDto));
                
                if (references.TryGetValue(key, out cache))
                {
                    return (ManufacturerDto)cache;
                }
                ManufacturerDto result = new ManufacturerDto();
                references[key] = (object)result;
                
                result.Id = p12.Id;
                
                if (p12.ManufacturerName != null)
                {
                    result.ManufacturerName = p12.ManufacturerName;
                }
                
                if (p12.Description != null)
                {
                    result.Description = p12.Description;
                }
                
                if (p12.Country != null)
                {
                    result.Country = p12.Country;
                }
                
                if (p12.ManufacturerLogos != null)
                {
                    result.ManufacturerLogos = null;
                }
                
                if (p12.Products != null)
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
        
        private static ProductDto funcMain12(Product p14)
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
                ReferenceTuple key = new ReferenceTuple(p14, typeof(ProductDto));
                
                if (references.TryGetValue(key, out cache))
                {
                    return (ProductDto)cache;
                }
                ProductDto result = new ProductDto();
                references[key] = (object)result;
                
                result.Id = p14.Id;
                
                if (p14.ProductName != null)
                {
                    result.ProductName = p14.ProductName;
                }
                
                if (p14.ProductDescription != null)
                {
                    result.ProductDescription = p14.ProductDescription;
                }
                result.ProductPrice = p14.ProductPrice;
                result.ProductWeight = p14.ProductWeight;
                result.ProductQuantityInStock = p14.ProductQuantityInStock;
                result.IdCategory = p14.IdCategory;
                result.IdManufacturer = p14.IdManufacturer;
                
                if (p14.IdCategoryNavigation != null)
                {
                    result.IdCategoryNavigation = null;
                }
                
                if (p14.IdManufacturerNavigation != null)
                {
                    result.IdManufacturerNavigation = null;
                }
                
                if (p14.ProductImages != null)
                {
                    result.ProductImages = null;
                }
                
                if (p14.Scores != null)
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
        
        private static CategoryDto funcMain14(Category p16)
        {
            if (p16 == null)
            {
                return null;
            }
            MapContextScope scope = new MapContextScope();
            
            try
            {
                object cache;
                
                Dictionary<ReferenceTuple, object> references = scope.Context.References;
                ReferenceTuple key = new ReferenceTuple(p16, typeof(CategoryDto));
                
                if (references.TryGetValue(key, out cache))
                {
                    return (CategoryDto)cache;
                }
                CategoryDto result = new CategoryDto();
                references[key] = (object)result;
                
                result.Id = p16.Id;
                
                if (p16.CategoryName != null)
                {
                    result.CategoryName = p16.CategoryName;
                }
                
                if (p16.Products != null)
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
        
        private static ScoreDto funcMain16(Score p18)
        {
            if (p18 == null)
            {
                return null;
            }
            MapContextScope scope = new MapContextScope();
            
            try
            {
                object cache;
                
                Dictionary<ReferenceTuple, object> references = scope.Context.References;
                ReferenceTuple key = new ReferenceTuple(p18, typeof(ScoreDto));
                
                if (references.TryGetValue(key, out cache))
                {
                    return (ScoreDto)cache;
                }
                ScoreDto result = new ScoreDto();
                references[key] = (object)result;
                
                result.Id = p18.Id;
                result.NumberScore = p18.NumberScore;
                
                if (p18.TextScore != null)
                {
                    result.TextScore = p18.TextScore;
                }
                result.IdProduct = p18.IdProduct;
                
                if (p18.IdProductNavigation != null)
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