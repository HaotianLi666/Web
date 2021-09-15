/* File: PlantController.cs
 * Authors: Jonathan Wenek, Cameron Carley, Stephanie Cameron
 * Purpose: Controller for the Plant repository, inherits from ControllerBase
 * Functions: 
 *      PlantController(), GetAllPlants(), GetPlantById(), CreatePlant(), UpdatePlant(), DeletePlant() */

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using Sprouty.Contracts;
using Sprouty.Entities.DataTransferObjects;
using System;
using System.Collections.Generic;

namespace Sprouty.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlantController : ControllerBase
    {
        private IRepositoryWrapper _repository;
        private IMapper _mapper;
        private ILogger _logger;

        public PlantController(IRepositoryWrapper repository, IMapper mapper, ILogger logger)
        {
            _repository = repository;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetAllPlants()
        {
            try
            {
                var users = _repository.User.GetAll();
                var result = _mapper.Map<IEnumerable<PlantDto>>(users);
                return Ok(result);
            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet("{id:length(24)}", Name = "PlantById")]
        public IActionResult GetPlantById(string id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public IActionResult CreatePlant([FromBody]PlantDto plant)
        {
            throw new NotImplementedException();
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult UpdatePlant(string id, [FromBody]PlantDto plant)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult DeletePlant(string id)
        {
            throw new NotImplementedException();
        }
    }
}
