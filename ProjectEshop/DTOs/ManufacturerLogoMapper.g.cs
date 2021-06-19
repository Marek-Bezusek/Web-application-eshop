using System.Collections.Generic;
using Mapster;
using Mapster.Utils;
using ProjectEshop.DTOs;
using ProjectEshop.Models;

namespace ProjectEshop.DTOs
{
    public static partial class ManufacturerLogoMapper
    {
        public static ManufacturerLogo AdaptToManufacturerLogo(this ManufacturerLogoDto p1)
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
                ReferenceTuple key = new ReferenceTuple(p1, typeof(ManufacturerLogo));
                
                if (references.TryGetValue(key, out cache))
                {
                    return (ManufacturerLogo)cache;
                }
                ManufacturerLogo result = new ManufacturerLogo();
                references[key] = (object)result;
                
                result.Id = p1.Id;
                
                if (p1.Logo != null)
                {
                    result.Logo = p1.Logo;
                }
                result.IdManufacturer = p1.IdManufacturer;
                return result;
            }
            finally
            {
                scope.Dispose();
            }
            
        }
        public static ManufacturerLogoDto AdaptToDto(this ManufacturerLogo p2)
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
                ReferenceTuple key = new ReferenceTuple(p2, typeof(ManufacturerLogoDto));
                
                if (references.TryGetValue(key, out cache))
                {
                    return (ManufacturerLogoDto)cache;
                }
                ManufacturerLogoDto result = new ManufacturerLogoDto();
                references[key] = (object)result;
                
                result.Id = p2.Id;
                
                if (p2.Logo != null)
                {
                    result.Logo = p2.Logo;
                }
                result.IdManufacturer = p2.IdManufacturer;
                return result;
            }
            finally
            {
                scope.Dispose();
            }
            
        }
    }
}