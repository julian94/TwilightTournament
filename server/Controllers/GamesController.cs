using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GamesController : ControllerBase
{
    [HttpGet("")]
    public async Task<ActionResult> ListGames()
    {
        throw new NotImplementedException();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult> GetGameInfo(string id)
    {
        throw new NotImplementedException();
    }

    [Authorize]
    [HttpPut("{id}")]
    public async Task<ActionResult> SetGameLink(string id, [FromBody] string url)
    {
        throw new NotImplementedException();
    }
}
