using Flurl.Http;
using System.Threading.Tasks;

using Server.Polling.TwilightWars;
using System.Collections.Generic;

namespace Server.Polling;

public class TwilightStatusReader(string AuthCookie)
{
    private const string PlayersPath = "players";
    private const string SummaryPath = "summary";


    public async Task<GameState> GetGameState(string id)
    {
        var summary = await GetGameSummary(id);

        var players = await GetPlayers(id);

        var playerList = new List<PlayerState>();

        foreach (var player in players)
        {
            playerList.Add(new ()
            {
                Avatar = player.User.Avatar,
                ID = player.User.Id,
                Name = player.User.Username,
                VictoryPoints = player.VictoryPoints,
            });
        }

        var state = new GameState()
        {
            Name = summary.Name,
            Phase = summary.Phase,
            Round = summary.Round,
            Over = summary.Over,
            Players = playerList,
        };

        return state;
    }

    private async Task<Summary> GetGameSummary(string id)
    {
        var response = await $"https://www.twilightwars.com/games/{id}/{SummaryPath}"
            .WithHeader("Cookie", AuthCookie)
            .GetJsonAsync<Summary>();

        return response;
    }
    private async Task<List<PlayerFull>> GetPlayers(string id)
    {
        var response = await $"https://www.twilightwars.com/games/{id}/{PlayersPath}"
            .WithHeader("Cookie", AuthCookie)
            .GetJsonAsync<List<PlayerFull>>();

        return response;
    }
}
