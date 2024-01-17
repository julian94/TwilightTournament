using System.Collections.Generic;

namespace Server.Games;

public class Bracket
{
    public List<Game> Calculate(List<Player> players, BracketSettings settings)
    {
        var games = new List<Game>();

        // TODO: Calculate the bracket.

        return games;
    }
}


public class BracketSettings
{
    public required int PlayersPerGame { get; init; }
    public required int RoundsPerPlayer { get; init; }
    public required bool PlayersMayMeetTwice { get; init; }
}
