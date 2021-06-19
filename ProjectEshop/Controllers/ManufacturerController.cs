using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using Mapster;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using ProjectEshop.Models;
using ProjectEshop.Repository;
using ProjectEshop.DTOs;

namespace ProjectEshop.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ManufacturerController : ControllerBase
    {
        #region private properties

        private readonly IRepository<Manufacturer> manufacturerRepository;

        #endregion

        #region ctor
        public ManufacturerController(IRepository<Manufacturer> manufacturerRepository)
        {

            this.manufacturerRepository = manufacturerRepository;
        }
        #endregion

        #region public GET methods

        [HttpGet]
        [Route("ManufacturerGetAll")]
        public ActionResult<IEnumerable<ManufacturerDto>> GetAllManufacturers()
        {
            var manufacturers = manufacturerRepository.Get(includeProperties: "ManufacturerLogos").ToList();
            return manufacturers.Select(x => x.AdaptToDto()).ToList();
        }

        [HttpGet]
        [Route("ManufacturerGetDetail")]
        public ActionResult<ManufacturerDto> GetManufacturerDetail(int id)
        {
            var result =
                manufacturerRepository.GetById(id, includeProperties: "Products,ManufacturerLogos");
            if (result is null)
            {
                return NoContent();
            }

            return result.AdaptToDto();
        }

        #endregion

        #region public POST methods

        [HttpPost]
        [Route("ManufacturerCreate")]
        public ActionResult<int> CreateManufacturer(ManufacturerDto newManufacturerDto)
        {
            var newManufacturer = newManufacturerDto.AdaptToManufacturer();
            manufacturerRepository.Insert(newManufacturer);

            if (manufacturerRepository.Commit() < 1)
            {
                return Problem();
            }

            return newManufacturer.Id;
        }

        [HttpPut]
        [Route("ManufacturerEdit")]
        public IActionResult EditManufacturer(ManufacturerDto manufacturerEditDataDto)
        {
            var manufacturerEditData = manufacturerEditDataDto.AdaptToManufacturer();
            var manufacturerToEdit = manufacturerRepository.GetById(manufacturerEditData.Id, includeProperties: "ManufacturerLogos");
            if (manufacturerToEdit == null)
            {
                return NoContent();
            }


            manufacturerToEdit.ManufacturerName = manufacturerEditData.ManufacturerName;
            manufacturerToEdit.Country = manufacturerEditData.Country;
            manufacturerToEdit.Description = manufacturerEditData.Description;
            manufacturerToEdit.ManufacturerLogos = manufacturerEditData.ManufacturerLogos;

            manufacturerRepository.Commit();
            return Ok();
        }


        #endregion


        #region public delete methods


        [HttpDelete]
        [Route("ManufacturerDelete")]
        public IActionResult DeleteManufacturer(int id)
        {

            manufacturerRepository.Delete(id);
            if (manufacturerRepository.Commit() < 1)
            {
                return Problem();
            }
            return Ok();
        }

        #endregion

    }

}


