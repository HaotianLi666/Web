<<<<<<< HEAD
﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
=======
﻿/* File: PlantController.cs
 * Authors: Jonathan Wenek, Cameron Carley, Stephanie Cameron
 * Purpose: Controller for the Plant repository, inherits from ControllerBase
 * Functions: 
 *      PlantController(), GetAllPlants(), GetPlantById(), CreatePlant(), UpdatePlant(), DeletePlant() */

using AutoMapper;
>>>>>>> master
using Microsoft.AspNetCore.Mvc;
using Serilog;
using Sprouty.Contracts;
using Sprouty.Entities.DataTransferObjects;
using Sprouty.Entities.Models;
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
                var users = _repository.User.GetAllUsers();
                var result = _mapper.Map<IEnumerable<PlantDto>>(users);
                return Ok(result);
            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error");
            }
        }

<<<<<<< HEAD
        // GET: /plant
        /// <summary>
        /// Get collection of plants.
        /// </summary>
        /// <returns>A collection of plants</returns>
        /// <response code="200">Returns a collection of plants</response>
        /// <response code="404">No plants exist within the DB</response>     
        /// <response code="500">Internal error</response>      
        [HttpGet("/plant/")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpGet]
        public IActionResult GetAllOwners()
        {
            try
            {
                var plants = _repository.Plant.GetAllPlants();

                if (plants == null)
                {
                    return NotFound("No plants exist");
                }

                /*_logger.LogInfo($"Returned all owners from database.");*/
                return Ok(plants);
            }
            catch (Exception ex)
            {
               /* _logger.LogError($"Something went wrong inside GetAllOwners action: {ex.Message}");*/
                return StatusCode(500, "Internal server error");
            }
        }


        // TODO : implement the rest of the controller functions, see UML
=======
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
>>>>>>> master
    }
}
