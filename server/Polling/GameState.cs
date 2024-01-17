using System.Collections.Generic;

namespace Server.Polling;

public class GameState
{
    public List<PlayerState> Players { get; set; }
    public int Round { get; set; }
    public string Phase { get; set; }
    public string Name { get; set; }
}

public class PlayerState
{
    public string Name { get; set; }
    public string ID { get; set; }
    public string? Avatar { get; set; }
    public int VictoryPoints { get; set; }
}