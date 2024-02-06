namespace DotNetSample.Api.Controllers;

using DotNetSample.Application.DTOs;
using DotNetSample.Domain.Entities;
using DotNetSample.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class UserController(IUserService userService) : ControllerBase {

    [HttpPost]
    public async Task<ActionResult<User>> Login([FromBody] LoginDto loginDetails){
        //Add in some checks for email address and password
        //make sure the email addres is populated
        var emailAddress = loginDetails.EmailAddress ?? string.Empty;
        var password = loginDetails.Password ?? string.Empty;

        return Ok(await userService.Login(emailAddress, password));
    }
}

