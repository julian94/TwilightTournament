using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AdminController : ControllerBase
{
    /// <summary>
    /// Open a new tournament
    /// </summary>\
    [Authorize]
    [HttpPost("open")]
    public async Task<ActionResult> Open()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Lock in the current users and start the tournament
    /// </summary>\
    [Authorize]
    [HttpPost("start")]
    public async Task<ActionResult> Start()
    {
        throw new NotImplementedException();
    }
}
