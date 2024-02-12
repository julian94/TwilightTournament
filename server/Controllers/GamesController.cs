using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Server.Polling;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GamesController(TwilightStatusReader statusReader) : ControllerBase
{
    [HttpGet("")]
    public async Task<ActionResult> ListGames()
    {
        var tourneyGames = new List<string>()
        {
            "64d02381fe17c6001496b965",
        };

        return new ObjectResult(tourneyGames);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult> GetGameInfo(string id)
    {
        var status = await statusReader.GetGameState(id);

        return new ObjectResult(status);
    }

    [Authorize]
    [HttpPut("{id}")]
    public async Task<ActionResult> SetGameLink(string id, [FromBody] string url)
    {
        throw new NotImplementedException();
    }
}
