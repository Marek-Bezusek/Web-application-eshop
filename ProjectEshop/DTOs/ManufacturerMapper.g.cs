using System.Collections.Generic;
using Mapster;
using Mapster.Utils;
using ProjectEshop.DTOs;
using ProjectEshop.Models;

namespace ProjectEshop.DTOs
{
    public static partial class ManufacturerMapper
    {
        public static Manufacturer AdaptToManufacturer(this ManufacturerDto p1)
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
                ReferenceTuple key = new ReferenceTuple(p1, typeof(Manufacturer));
                
                if (references.TryGetValue(key, out cache))
                {
                    return (Manufacturer)cache;
                }
                Manufacturer result = new Manufacturer();
                references[key] = (object)result;
                
                result.Id = p1.Id;
                
                if (p1.ManufacturerName != null)
                {
                    result.ManufacturerName = p1.ManufacturerName;
                }
                
                if (p1.Description != null)
                {
                    result.Description = p1.Description;
                }
                
                if (p1.Country != null)
                {
                    result.Country = p1.Country;
                }
                
                if (p1.ManufacturerLogos != null)
                {
                    result.ManufacturerLogos = funcMain1(p1.ManufacturerLogos);
                }
                
                if (p1.Products != null)
                {
                    result.Products = funcMain3(p1.Products);
                }
                return result;
            }
            finally
            {
                scope.Dispose();
            }
            
        }
        public static ManufacturerDto AdaptToDto(this Manufacturer p6)
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
                ReferenceTuple key = new ReferenceTuple(p6, typeof(ManufacturerDto));
                
                if (references.TryGetValue(key, out cache))
                {
                    return (ManufacturerDto)cache;
                }
                ManufacturerDto result = new ManufacturerDto();
                references[key] = (object)result;
                
                result.Id = p6.Id;
                
                if (p6.ManufacturerName != null)
                {
                    result.ManufacturerName = p6.ManufacturerName;
                }
                
                if (p6.Description != null)
                {
                    result.Description = p6.Description;
                }
                
                if (p6.Country != null)
                {
                    result.Country = p6.Country;
                }
                
                if (p6.ManufacturerLogos != null)
                {
                    result.ManufacturerLogos = funcMain5(p6.ManufacturerLogos);
                }
                
                if (p6.Products != null)
                {
                    result.Products = funcMain7(p6.Products);
                }
                return result;
            }
            finally
            {
                scope.Dispose();
            }
            
        }
        
        private static ICollection<ManufacturerLogo> funcMain1(ICollection<ManufacturerLogoDto> p2)
        {
            if (p2 == null)
            {
                return null;
            }
            ICollection<ManufacturerLogo> result = new List<ManufacturerLogo>(p2.Count);
            
            IEnumerator<ManufacturerLogoDto> enumerator = p2.GetEnumerator();
            
            while (enumerator.MoveNext())
            {
                ManufacturerLogoDto item = enumerator.Current;
                result.Add(funcMain2(item));
            }
            return result;
            
        }
        
        private static ICollection<Product> funcMain3(ICollection<ProductDto> p4)
        {
            if (p4 == null)
            {
                return null;
            }
            ICollection<Product> result = new List<Product>(p4.Count);
            
            IEnumerator<ProductDto> enumerator = p4.GetEnumerator();
            
            while (enumerator.MoveNext())
            {
                ProductDto item = enumerator.Current;
                result.Add(funcMain4(item));
            }
            return result;
            
        }
        
        private static ICollection<ManufacturerLogoDto> funcMain5(ICollection<ManufacturerLogo> p7)
        {
            if (p7 == null)
            {
                return null;
            }
            ICollection<ManufacturerLogoDto> result = new List<ManufacturerLogoDto>(p7.Count);
            
            IEnumerator<ManufacturerLogo> enumerator = p7.GetEnumerator();
            
            while (enumerator.MoveNext())
            {
                ManufacturerLogo item = enumerator.Current;
                result.Add(funcMain6(item));
            }
            return result;
            
        }
        
        private static ICollection<ProductDto> funcMain7(ICollection<Product> p9)
        {
            if (p9 == null)
            {
                return null;
            }
            ICollection<ProductDto> result = new List<ProductDto>(p9.Count);
            
            IEnumerator<Product> enumerator = p9.GetEnumerator();
            
            while (enumerator.MoveNext())
            {
                Product item = enumerator.Current;
                result.Add(funcMain8(item));
            }
            return result;
            
        }
        
        private static ManufacturerLogo funcMain2(ManufacturerLogoDto p3)
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
                ReferenceTuple key = new ReferenceTuple(p3, typeof(ManufacturerLogo));
                
                if (references.TryGetValue(key, out cache))
                {
                    return (ManufacturerLogo)cache;
                }
                ManufacturerLogo result = new ManufacturerLogo();
                references[key] = (object)result;
                
                result.Id = p3.Id;
                
                if (p3.Logo != null)
                {
                    result.Logo = p3.Logo;
                }
                result.IdManufacturer = p3.IdManufacturer;
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
        
        private static ManufacturerLogoDto funcMain6(ManufacturerLogo p8)
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
                ReferenceTuple key = new ReferenceTuple(p8, typeof(ManufacturerLogoDto));
                
                if (references.TryGetValue(key, out cache))
                {
                    return (ManufacturerLogoDto)cache;
                }
                ManufacturerLogoDto result = new ManufacturerLogoDto();
                references[key] = (object)result;
                
                result.Id = p8.Id;
                
                if (p8.Logo != null)
                {
                    result.Logo = p8.Logo;
                }
                result.IdManufacturer = p8.IdManufacturer;
                return result;
            }
            finally
            {
                scope.Dispose();
            }
            
        }
        
        private static ProductDto funcMain8(Product p10)
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
                ReferenceTuple key = new ReferenceTuple(p10, typeof(ProductDto));
                
                if (references.TryGetValue(key, out cache))
                {
                    return (ProductDto)cache;
                }
                ProductDto result = new ProductDto();
                references[key] = (object)result;
                
                result.Id = p10.Id;
                
                if (p10.ProductName != null)
                {
                    result.ProductName = p10.ProductName;
                }
                
                if (p10.ProductDescription != null)
                {
                    result.ProductDescription = p10.ProductDescription;
                }
                result.ProductPrice = p10.ProductPrice;
                result.ProductWeight = p10.ProductWeight;
                result.ProductQuantityInStock = p10.ProductQuantityInStock;
                result.IdCategory = p10.IdCategory;
                result.IdManufacturer = p10.IdManufacturer;
                
                if (p10.IdCategoryNavigation != null)
                {
                    result.IdCategoryNavigation = null;
                }
                
                if (p10.IdManufacturerNavigation != null)
                {
                    result.IdManufacturerNavigation = null;
                }
                
                if (p10.ProductImages != null)
                {
                    result.ProductImages = null;
                }
                
                if (p10.Scores != null)
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