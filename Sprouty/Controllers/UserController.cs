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
                // TODO : add logging
                return StatusCode(500, "Internal server error");
            }
        }

        // TODO : implement the rest of the controller functions, see UML
    }
}
