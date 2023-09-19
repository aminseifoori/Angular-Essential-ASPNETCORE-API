﻿using Angular_Essential_API.Dtos;
using Angular_Essential_API.ServiceInterface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Angular_Essential_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService service;

        public UsersController(IUserService _Service)
        {
            service = _Service;
        }

        [HttpPost]
        public async Task<IActionResult> RegisterUser([FromBody] CreateUserDto createUserDto)
        {
            if (ModelState.IsValid)
            {
                var result = await service.RegisterUser(createUserDto);
                if (!result.Succeeded)
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.TryAddModelError(error.Code, error.Description);
                    }
                    return BadRequest(ModelState);
                }
                return StatusCode(201);
            }
            return new UnprocessableEntityObjectResult(ModelState);
        }

        [HttpPost("RegisterAdmin")]
        public async Task<IActionResult> RegisterAdmin([FromBody] CreateUserDto createUserDto)
        {
            if (ModelState.IsValid)
            {
                var result = await service.RegisterAdmin(createUserDto);
                if (!result.Succeeded)
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.TryAddModelError(error.Code, error.Description);
                    }
                    return BadRequest(ModelState);
                }
                return StatusCode(201);
            }
            return new UnprocessableEntityObjectResult(ModelState);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Authenticate([FromBody] LoginDto user)
        {
            if (ModelState.IsValid)
            {
                if (!await service.ValidateUser(user))
                    return Unauthorized();
                var tokenDto = await service.CreateToken(true);
                return Ok(tokenDto);
            }
            return new UnprocessableEntityObjectResult(ModelState);
        }

        [HttpPost("refresh")]
        public async Task<IActionResult> Refresh([FromBody] TokenDto tokenDto)
        {
            if (ModelState.IsValid)
            {
                var tokenDtoToReturn = await service.RefreshToken(tokenDto);
                return Ok(tokenDtoToReturn);
            }
            return new UnprocessableEntityObjectResult(ModelState);
        }
    }
}
