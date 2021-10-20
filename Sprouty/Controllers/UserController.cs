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
using Sprouty.Entities.Models;
using System;
using Sprouty.Services;
using Sprouty.Helpers;

namespace Sprouty.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService _userservice;
        private IRepositoryWrapper _repository;
        private IMapper _mapper;
        private ILogger _logger;

        public UserController(IUserService userservice, IRepositoryWrapper repository, IMapper mapper, ILogger logger)
        {
            _userservice = userservice;
            _repository = repository;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpPost("authenticate")]
        public IActionResult Authenticate(AuthenticateRequest model)
        {
            if (model == null)
                return BadRequest("Authentication request model is null");

            if (!ModelState.IsValid)
                return BadRequest("Invalid model object");

            var response = _repository.User.Authenticate(model);

            if (response == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(response);
        }

        //[Authorize]
        [HttpGet("{id:length(24)}", Name = "UserById")]
        public IActionResult GetUserById(string id)
        {
            try
            {
                var user = _repository.User.GetUserById(id);

                if (user == null)
                    return NotFound();

                var result = _mapper.Map<UserDto>(user);
                return Ok(result);
            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPost]
        public IActionResult CreateUser([FromBody] NewUserDto user)
        {
            try
            {
                if (user == null)
                    return BadRequest("User object is null");

                if (!ModelState.IsValid)
                    return BadRequest("Invalid model object");

                if (_repository.User.GetUserByEmail(user.EmailAddress) != null)
                    return BadRequest("An account with the given email address already exists");

                var userEntity = _mapper.Map<User>(user);

                // update userEntity with hashed password and salt before writing document to the database
                userEntity.Salt = _userservice.GenerateSalt();
                userEntity.Password = _userservice.HashPassword(userEntity.Password, userEntity.Salt);
                userEntity.Plants = new Plant[] { };

                _repository.User.CreateUser(userEntity);

                var newUser = _mapper.Map<UserDto>(userEntity);

                return StatusCode(200);
            } 
            catch (Exception e) 
            {
                return StatusCode(500, "Internal server error");
            }
        }

        //[Authorize]
        [HttpPut("{id:length(24)}")]
        public IActionResult UpdateUser(string id, [FromBody] UserDto user)
        {
            try
            {
                if (user == null)
                    return BadRequest("User object is null, unable to perform update");

                if (!ModelState.IsValid)
                    return BadRequest("User object is not a valid model");

                var userEntity = _repository.User.GetUserById(id);

                if (userEntity == null)
                    return NotFound();

                _mapper.Map(user, userEntity);
                _repository.User.UpdateUser(id, userEntity);
                return NoContent();
            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }

        //[Authorize]
        [HttpDelete("{id:length(24)}")]
        public IActionResult DeleteUser(string id)
        {
            try
            {
                var user = _repository.User.GetUserById(id);
                if (user == null)
                {
                    return NotFound();
                }

                _repository.User.DeleteUser(id);
                return NoContent();
            }
            catch (Exception e)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }
    }
}
