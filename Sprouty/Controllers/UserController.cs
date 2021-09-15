/* File: UserController.cs
 * Authors: Jonathan Wenek, Cameron Carley, Stephanie Cameron
 * Purpose: Controller for the User repository, inherits from ControllerBase
 * Functions: 
 *      UserController(), GetAllUsers(), GetUserById(), CreateUser(), UpdateUser(), DeleteUser() */

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
    public class UserController : ControllerBase
    {
        private IRepositoryWrapper _repository;
        private IMapper _mapper;
        private ILogger _logger;

        public UserController(IRepositoryWrapper repository, IMapper mapper, ILogger logger)
        {
            _repository = repository;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetAllUsers()
        {
            try
            {
                var users = _repository.User.GetAll();
                var result = _mapper.Map<IEnumerable<UserDto>>(users);
                return Ok(result);
            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet("{id:length(24)}", Name = "UserById")]
        public IActionResult GetUserById(string id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public IActionResult CreateUser([FromBody] UserDto user)
        {
            throw new NotImplementedException();
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult UpdateUser(string id, [FromBody] UserDto user)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult DeleteUser(string id)
        {
            throw new NotImplementedException();
        }
    }
}
