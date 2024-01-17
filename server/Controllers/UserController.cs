using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    /// <summary>
    /// Register a new user
    /// </summary>\
    [Authorize]
    [HttpPost("register")]
    public async Task<ActionResult> Register()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Register a user into a tournament
    /// </summary>\
    [Authorize]
    [HttpPost("enter")]
    public async Task<ActionResult> Enter()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Remove a user from a tournament before it starts.
    /// </summary>\
    [Authorize]
    [HttpPost("leave")]
    public async Task<ActionResult> Leave()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Delete a user account
    /// </summary>\
    [Authorize]
    [HttpDelete]
    public async Task<ActionResult> Delete()
    {
        throw new NotImplementedException();
    }
}
