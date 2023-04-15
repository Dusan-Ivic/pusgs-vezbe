using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zadatak1.Interfaces;
using Zadatak1.Models.DTO;

namespace Zadatak1.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public IActionResult Register([FromBody] UserDTO dto)
        {
            string username = _userService.Register(dto);

            if (username == null)
            {
                return Unauthorized();
            }

            return Ok(username);
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] UserDTO dto)
        {
            string token = _userService.Login(dto);

            if (token == null)
            {
                return Unauthorized();
            }

            return Ok(token);
        }

        [HttpGet("custom")]
        [Authorize(Policy = "CustomClaimPolicy")]
        public IActionResult TestCustomClaim()
        {
            return Ok("CUSTOM CLAIM");
        }

        [HttpGet("user")]
        [Authorize(Roles = "user")]
        public IActionResult UserClaim()
        {
            return Ok("You are: USER");
        }

        [HttpGet("admin")]
        [Authorize(Roles = "admin")]
        public IActionResult AdminClaim()
        {
            return Ok("You are: ADMIN");
        }
    }
}
