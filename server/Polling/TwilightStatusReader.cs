using System;
using System.Threading.Tasks;

namespace Server.Polling;

public class TwilightStatusReader
{
    private const string PlayersPath = "/players";
    private const string SummaryPath = "/summary";

    public async Task<GameState> GetGameState(Uri gameUri)
    {
        throw new NotImplementedException();
    }
}
