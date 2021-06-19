using Mapster;
using ProjectEshop.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace ProjectEshop
{
    public class MyRegister : ICodeGenerationRegister
    {
        public void Register(CodeGenerationConfig config)
        {
            //config.AdaptTo("[name]Dto")
            //    //.ForType<Manufacturer>(c=> { c.Map(x => x.Description, "popis"); })
                
            //    .ForAllTypesInNamespace(Assembly.GetExecutingAssembly(), "ProjectEshop.Models")
            //    .ExcludeTypes(typeof(EshopContext))
            //    ;

            config.AdaptTwoWays("[name]Dto", MapType.Map)
                //.ForType<Manufacturer>(c=> { c.Map(x => x.Description, "popis"); })
                .ForAllTypesInNamespace(Assembly.GetExecutingAssembly(), "ProjectEshop.Models")
                .ExcludeTypes(typeof(EshopContext))
                .ShallowCopyForSameType(true)
                .MaxDepth(2)
                .IgnoreNullValues(true)
                .PreserveReference(true)
                .ApplyDefaultRule()
                
            ;
            
            config.GenerateMapper("[name]Mapper")
                //.ForType<Manufacturer>()
                .ForAllTypesInNamespace(Assembly.GetExecutingAssembly(), "ProjectEshop.Models")
                .ExcludeTypes(typeof(EshopContext))
                ;
        }

        
    }
    static class RegisterExtensions
    {
        public static AdaptAttributeBuilder ApplyDefaultRule(this AdaptAttributeBuilder builder)
        {
            return builder
                .ForAllTypesInNamespace(Assembly.GetExecutingAssembly(), "ProjectEshop.Models")
                .ExcludeTypes(typeof(EshopContext))
                .IgnoreNullValues(true)
                .PreserveReference(true)
                .ForType<ManufacturerLogo>(cfg => cfg.Ignore(it => it.IdManufacturerNavigation))
                .ForType<ManufacturerLogo>(cfg => cfg.Ignore(it => it.IdManufacturerNavigation))
                ;


        }


    }
}
